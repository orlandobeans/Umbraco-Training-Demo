//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace CoreProject.Models.Published
{
	/// <summary>Contact</summary>
	[PublishedContentModel("contact")]
	public partial class Contact : PublishedContentModel, INavigationBase
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "contact";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Contact(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Contact, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// ApiKey: To use the map you'll need your own Google API key. More information here: https://developers.google.com/maps/documentation/javascript/error-messages#no-api-keys
		///</summary>
		[ImplementPropertyType("apiKey")]
		public string ApiKey
		{
			get { return this.GetPropertyValue<string>("apiKey"); }
		}

		///<summary>
		/// Pick a Contact Form: If Umbraco Forms is installed you'll be able to select a form here.
		///</summary>
		[ImplementPropertyType("contactForm")]
		public string ContactForm
		{
			get { return this.GetPropertyValue<string>("contactForm"); }
		}

		///<summary>
		/// Contact Form Header
		///</summary>
		[ImplementPropertyType("contactFormHeader")]
		public string ContactFormHeader
		{
			get { return this.GetPropertyValue<string>("contactFormHeader"); }
		}

		///<summary>
		/// Contact Intro
		///</summary>
		[ImplementPropertyType("contactIntro")]
		public IHtmlString ContactIntro
		{
			get { return this.GetPropertyValue<IHtmlString>("contactIntro"); }
		}

		///<summary>
		/// Your Address: Plot your address on the map and it'll be displayed on the contact page
		///</summary>
		[ImplementPropertyType("map")]
		public Terratype.Models.Model Map
		{
			get { return this.GetPropertyValue<Terratype.Models.Model>("map"); }
		}

		///<summary>
		/// Map Header
		///</summary>
		[ImplementPropertyType("mapHeader")]
		public string MapHeader
		{
			get { return this.GetPropertyValue<string>("mapHeader"); }
		}

		///<summary>
		/// Page Title: The title of the page, this is also the first text in a google search result. The ideal length is between 40 and 60 characters
		///</summary>
		[ImplementPropertyType("pageTitle")]
		public string PageTitle
		{
			get { return this.GetPropertyValue<string>("pageTitle"); }
		}

		///<summary>
		/// Keywords: Keywords that describe the content of the page. This is consired optional since most modern search engines don't use this anymore
		///</summary>
		[ImplementPropertyType("keywords")]
		public IEnumerable<string> Keywords
		{
			get { return CoreProject.Models.Published.NavigationBase.GetKeywords(this); }
		}

		///<summary>
		/// Description: A brief description of the content on your page. This text is shown below the title in a google search result and also used for Social Sharing Cards. The ideal length is between 130 and 155 characters
		///</summary>
		[ImplementPropertyType("seoMetaDescription")]
		public string SeoMetaDescription
		{
			get { return CoreProject.Models.Published.NavigationBase.GetSeoMetaDescription(this); }
		}

		///<summary>
		/// Hide in Navigation: If you don't want this page to appear in the navigation, check this box
		///</summary>
		[ImplementPropertyType("umbracoNavihide")]
		public bool UmbracoNavihide
		{
			get { return CoreProject.Models.Published.NavigationBase.GetUmbracoNavihide(this); }
		}
	}
}
