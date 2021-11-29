using CsCodeGenerator;
using Salesforce.Force;
using System;
using System.IO;
using System.Threading.Tasks;

namespace MAD.API.Salesforce.CodeGenerator
{
    public class ModelGenerator
    {
        private readonly IForceClient forceClient;

        public ModelGenerator(IForceClient forceClient)
        {
            this.forceClient = forceClient;
        }

        public async Task<string> Generate(string entityName, string ns)
        {
            var describe = await this.forceClient.DescribeAsync<DescribeResponse>(entityName);
            var classModel = new ClassModel(entityName)
            {
                AccessModifier = CsCodeGenerator.Enums.AccessModifier.Public,
                Interfaces = { "ISalesforceEntity" }
            };

            foreach (var f in describe.Fields)
            {
                var prop = new CsCodeGenerator.Property
                {
                    Name = f.Name,
                    Comment = f.Label,
                    AccessModifier = CsCodeGenerator.Enums.AccessModifier.Public
                };

                switch (f.Type)
                {
                    case "reference":
                    case "id":
                    case "string":
                    case "picklist":
                    case "textarea":
                    case "location":
                        prop.BuiltInDataType = CsCodeGenerator.Enums.BuiltInDataType.String;
                        break;

                    case "boolean":
                        prop.BuiltInDataType = CsCodeGenerator.Enums.BuiltInDataType.Bool;
                        break;

                    case "datetime":
                    case "date":
                        prop.CustomDataType = "DateTime";
                        break;

                    case "int":
                        prop.BuiltInDataType = CsCodeGenerator.Enums.BuiltInDataType.Int;
                        break;

                    case "double":
                        prop.BuiltInDataType = CsCodeGenerator.Enums.BuiltInDataType.Double;
                        break;

                    default: throw new NotImplementedException(f.Type);
                }

                classModel.Properties.Add(prop);
            }

            var fileModel = new FileModel
            {
                Classes = { classModel },
                Namespace = ns,
                Name = entityName,
                UsingDirectives =
                {
                    "System;"
                }
            };

            return fileModel.ToString();
        }
    }
}
