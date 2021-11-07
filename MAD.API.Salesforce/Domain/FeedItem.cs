﻿using MAD.API.Salesforce.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAD.API.Salesforce.Domain
{
    public class FeedItem : ISalesforceEntity
    {
		///<summary>
		/// Feed Item ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		public string Id { get; set; }

		///<summary>
		/// Parent ID
		/// <para>Name: ParentId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "parentId")]
		public string ParentId { get; set; }

		///<summary>
		/// Feed Item Type
		/// <para>Name: Type</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "type")]
		public string Type { get; set; }

		///<summary>
		/// Created By ID
		/// <para>Name: CreatedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdById")]
		public string CreatedById { get; set; }

		///<summary>
		/// Created Date
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		public DateTimeOffset? CreatedDate { get; set; }

		///<summary>
		/// Deleted
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		public bool? IsDeleted { get; set; }

		///<summary>
		/// Last Modified Date
		/// <para>Name: LastModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedDate")]
		public DateTimeOffset? LastModifiedDate { get; set; }

		///<summary>
		/// System Modstamp
		/// <para>Name: SystemModstamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "systemModstamp")]
		public DateTimeOffset? SystemModstamp { get; set; }

		///<summary>
		/// Revision
		/// <para>Name: Revision</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "revision")]
		public int? Revision { get; set; }

		///<summary>
		/// Last Edit By ID
		/// <para>Name: LastEditById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastEditById")]
		public string LastEditById { get; set; }

		///<summary>
		/// Last Edit Date
		/// <para>Name: LastEditDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastEditDate")]
		public DateTimeOffset? LastEditDate { get; set; }

		///<summary>
		/// Comment Count
		/// <para>Name: CommentCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "commentCount")]
		public int? CommentCount { get; set; }

		///<summary>
		/// Like Count
		/// <para>Name: LikeCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "likeCount")]
		public int? LikeCount { get; set; }

		///<summary>
		/// Title
		/// <para>Name: Title</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "title")]
		public string Title { get; set; }

		///<summary>
		/// Body
		/// <para>Name: Body</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "body")]
		public string Body { get; set; }

		///<summary>
		/// Link Url
		/// <para>Name: LinkUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "linkUrl")]
		public string LinkUrl { get; set; }

		///<summary>
		/// Is Rich Text
		/// <para>Name: IsRichText</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isRichText")]
		public bool? IsRichText { get; set; }

		///<summary>
		/// Related Record ID
		/// <para>Name: RelatedRecordId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "relatedRecordId")]
		public string RelatedRecordId { get; set; }

		///<summary>
		/// InsertedBy ID
		/// <para>Name: InsertedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "insertedById")]
		public string InsertedById { get; set; }

		///<summary>
		/// Best Comment ID
		/// <para>Name: BestCommentId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "bestCommentId")]
		public string BestCommentId { get; set; }

		///<summary>
		/// Has Content
		/// <para>Name: HasContent</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasContent")]
		public bool? HasContent { get; set; }

		///<summary>
		/// Has Link
		/// <para>Name: HasLink</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasLink")]
		public bool? HasLink { get; set; }

		///<summary>
		/// Has Feed Entity Attachment
		/// <para>Name: HasFeedEntity</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasFeedEntity")]
		public bool? HasFeedEntity { get; set; }

		///<summary>
		/// Has Verified Comment
		/// <para>Name: HasVerifiedComment</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasVerifiedComment")]
		public bool? HasVerifiedComment { get; set; }

		///<summary>
		/// Is Closed
		/// <para>Name: IsClosed</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isClosed")]
		public bool? IsClosed { get; set; }

		///<summary>
		/// Status
		/// <para>Name: Status</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		public string Status { get; set; }

		[JsonProperty(PropertyName = "contentFileName")]
		public string ContentFileName { get; set; }

		[JsonProperty(PropertyName = "visibility")]
		public string Visibility { get; set; }
	}
}
