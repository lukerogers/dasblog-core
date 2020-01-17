﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using DasBlog.Core.Common.Comments;

namespace DasBlog.Web.Models.AdminViewModels
{
	public class SiteViewModel
	{
		[DisplayName("Title")]
		[Description("Main title of the blog")]
		[Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a blog title")]
		[StringLength(300, ErrorMessage = "{0} should be between 1 to 300 characters")]
		public string Title { get; set; }

		[DisplayName("Subtitle")]
		[Description("Subtitle of the blog")]
		[StringLength(300, ErrorMessage = "{0} should be between 1 to 300 characters")]
		public string Subtitle { get; set; }

		[DisplayName("Theme")]
		[Description("Allows you to select one of several themes in the 'themes' folder. You can also create your own theme folder and update this element accordingly")]
		[StringLength(300, ErrorMessage = "{0} should be between 1 to 300 characters")]
		public string Theme { get; set; }

		[DisplayName("Description")]
		[Description("A more detailed description of the blog")]
		[StringLength(300, MinimumLength = 0, ErrorMessage = "{0} should be between 1 to 300 characters")]
		public string Description { get; set; }

		[DisplayName("Email contact")]
		[Description("The email that you want to be publicly available, it also shows up in the RSS feed")]
		[EmailAddress]
		public string Contact { get; set; }

		[DisplayName("Notification email")]
		[Description("Private email where notifications will be sent")]
		[DataType(DataType.EmailAddress, ErrorMessage = "Invalid Email Address")]
		public string NotificationEMailAddress { get; set; }

		[DisplayName("Root URL")]
		[Description("This is the most important element for you to change. This element contains the external root URL of you Weblog. All relative links are built using this value, instead of relying on the URL that was used for the incoming request, because that URL may not be what we want to have, especially when the URLs come through a complex redirect")]
		[Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a valid site URL")]
		[DataType(DataType.Url, ErrorMessage = "Invalid URL format")]
		public string Root { get; set; }

		[DisplayName("Copyright")]
		[Description("Name of the sites copyright owner")]
		[StringLength(300, ErrorMessage = "{0} should be between 1 to 300 characters")]
		public string Copyright { get; set; }

		[DisplayName("Front page day count")]
		[Description("The maximum number of days to appear on your home page")]
		[Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a Front Page Day Count")]
		public int FrontPageDayCount { get; set; }

		[DisplayName("Front page entry count")]
		[Description("Number of blog posts on the home page of your blog")]
		[Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a Front Page Entry Count")]
		public int FrontPageEntryCount { get; set; }

		[DisplayName("Front page category")]
		[Description("Default category of the front page")]
		public string FrontPageCategory { get; set; }

		[DisplayName("Entries per page")]
		[Description(@"Number of blog posts on the pages of your blog e.g \page\1, page\2, etc")]
		[Required(AllowEmptyStrings = false, ErrorMessage = "Enter a value for Entries Per Page")]
		public int EntriesPerPage { get; set; }

		[DisplayName("Enable front page caching")]
		[Description("Uses standard web based caching on the server side (will increase memory usage).")]
		public bool EnableStartPageCaching { get; set; }

		[DisplayName("Days to look ahead for content")]
		[Description("Looks for future posts for this number of days into the future")]
		[Required(AllowEmptyStrings = false, ErrorMessage = "Enter a value for Content Look ahead Days")]
		public int ContentLookaheadDays { get; set; }

		[DisplayName("Show 'Item Summary' in Aggregated Views")]
		[Description("This allows you to design a summary view for each blog post on the home page")]
		public bool ShowItemSummaryInAggregatedViews { get; set; }

		[DisplayName("RSS day count")]
		[Description("Maximum number of days to appear in your RSS feed")]
		[Required(AllowEmptyStrings = false, ErrorMessage = "Enter a value for RSS Day Count")]
		public int RssDayCount { get; set; }

		[DisplayName("RSS main entry count")]
		[Description("The number of entries permitted in the main RSS feed")]
		[Required(AllowEmptyStrings = false, ErrorMessage = "Enter a value for RSS Main Entry Count")]
		public int RssMainEntryCount { get; set; }

		[DisplayName("RSS entry category count")]
		[Description("The number of entries permitted per RSS category feed")]
		[Required(AllowEmptyStrings = false, ErrorMessage = "Enter a value for RSS Entry Count")]
		public int RssEntryCount { get; set; }

		[DisplayName("Enable RSS item footer")]
		[Description("Include the message defined in RssItemFooter in the RSS Feed")]
		public bool EnableRssItemFooters { get; set; }

		[DisplayName("RSS footer")]
		[Description("The message to include in the RSS footer")]
		[StringLength(300)]
		public string RssItemFooter { get; set; }

		[DisplayName("Include content in RSS Feed")]
		[Description("Allows you to include blog content in RSS feeds")]
		public bool AlwaysIncludeContentInRSS { get; set; }

		[DisplayName("Enable comments")]
		[Description("Allow comments on your blog posts")]
		public bool EnableComments { get; set; }

		[DisplayName("Enable comment days limitation")]
		[Description("Once enabled comments are allowed as defined by 'Days Comments Allowed'")]
		public bool EnableCommentDays { get; set; }

		[DisplayName("Number of days comments allowed")]
		[Description("The number of days a post can receive comments after publishing when 'Enable Comment Days' is set to true")]
		[Required(AllowEmptyStrings = false, ErrorMessage = "Enter a value for Days Comments Allowed")]
		public int DaysCommentsAllowed { get; set; }

		[DisplayName("Show comments when viewing an entry")]
		[Description("Shows the comments associated with a blog post by default.")]
		public bool ShowCommentsWhenViewingEntry { get; set; }

		[DisplayName("Spam prevention question")]
		[Description("Cheesy Spam Question - Defines a question that end users need to answer before a comment is submitted (only enabled when CheesySpamA has a value).")]
		[StringLength(300, MinimumLength = 1, ErrorMessage = "{0} should be between 1 to 300 characters")]
		public string CheesySpamQ { get; set; }

		[DisplayName("Spam prevention answer")]
		[Description("Cheesy Spam Answer - Defines an answer that the commenters need to respond with in order to submit a comment (only enabled when CheesySpamQ has a val")]
		[StringLength(300, MinimumLength = 1, ErrorMessage = "{0} should be between 1 to 300 characters")]

		public string CheesySpamA { get; set; }


		[DisplayName("Enable unique URls")]
		[Description(@"Enable Title PermaLink Unique - Ensures all urls are unique by adding a date to the URL '\somepost' becomes '20191112\some - post'")]
		public bool EnableTitlePermaLinkUnique { get; set; }

		[DisplayName("Space replacement")]
		[Description(@"Defaults to '-', however, '+' is the other valid option")]
		[StringLength(1, MinimumLength = 1, ErrorMessage = "{0} should be 1 characters ('-' or '+'")]
		public string TitlePermalinkSpaceReplacement { get; set; }

		[DisplayName("Enable Blogger API")]
		[Description("")]
		public bool EnableBloggerApi { get; set; }
		
		[DisplayName("Preferred blogging API")]
		[Description("")]
		[StringLength(20, MinimumLength = 1, ErrorMessage = "{0} should be between 1 to 20 characters")]
		public string PreferredBloggingAPI { get; set; }

		[DisplayName("RSS channel image URL")]
		[Description("")]
		[StringLength(300, MinimumLength = 1, ErrorMessage = "{0} should be between 1 to 300 characters")]
		public string ChannelImageUrl { get; set; }

		[DisplayName("Web post edit control")]
		[Description("")]
		[StringLength(300, MinimumLength = 1, ErrorMessage = "{0} should be between 1 to 300 characters")]
		public string EntryEditControl { get; set; }

		[DisplayName("Content directory")]
		[Description("")]
		[StringLength(300, MinimumLength = 1, ErrorMessage = "{0} should be between 1 to 300 characters")]
		[Required(AllowEmptyStrings = false, ErrorMessage = "Enter a value for Content Directory")]
		public string ContentDir { get; set; }

		[DisplayName("Logging directory")]
		[Description("")]
		[StringLength(300, MinimumLength = 1, ErrorMessage = "{0} should be between 1 to 300 characters")]
		[Required(AllowEmptyStrings = false, ErrorMessage = "Enter a value for Logging Directory")]
		public string LogDir { get; set; }

		[DisplayName("Adjust time zone")]
		[Description("")]
		public bool AdjustDisplayTimeZone { get; set; }

		[DisplayName("Time zone index")]
		[Description("")]
		public int DisplayTimeZoneIndex { get; set; }

		[DisplayName("Comments require approval")]
		[Description("")]
		public bool CommentsRequireApproval { get; set; }

		[DisplayName("Send comment notification")]
		[Description("")]
		public bool SendCommentsByEmail { get; set; }

		[DisplayName("SMTP server")]
		[Description("")]
		public string SmtpServer { get; set; }

		[DisplayName("SMTP port")]
		[Description("")]
		public int SmtpPort { get; set; }

		[DisplayName("SMTP user name")]
		[Description("")]
		public string SmtpUserName { get; set; }

		[DisplayName("SMTP password")]
		[Description("")]
		[DataType(DataType.Password)]
		public string SmtpPassword { get; set; }

		[DisplayName("Use SSL with SMTP")]
		[Description("")]
		public bool UseSSLForSMTP { get; set; }


		public string BinariesDir { get; set; }
		public bool EntryTitleAsLink { get; set; }
		public bool ObfuscateEmail { get; set; }
		public bool SendReferralsByEmail { get; set; }
		public bool SendTrackbacksByEmail { get; set; }
		public bool SendPingbacksByEmail { get; set; }
		public bool SendPostsByEmail { get; set; }
		public bool EnableCommentApi { get; set; }
		public bool EnableConfigEditService { get; set; }
		public bool EnableEditService { get; set; }
		public bool EnableAutoPingback { get; set; }
		public bool ShowCommentCount { get; set; }
		public bool EnableTrackbackService { get; set; }
		public bool EnablePingbackService { get; set; }
		public bool EnableBlogrollDescription { get; set; }
		public bool EnableUrlRewriting { get; set; }
		public bool EnableCrossposts { get; set; }
		public bool UseUserCulture { get; set; }
		public bool EnableClickThrough { get; set; }
		public bool EnableAggregatorBugging { get; set; }
		public string EditPassword { get; set; }
		public string ProfilesDir { get; set; }
		public string BinariesDirRelative { get; set; }
		public bool EnablePop3 { get; set; }
		public string Pop3Server { get; set; }
		public string Pop3Username { get; set; }
		public string Pop3Password { get; set; }
		public string Pop3SubjectPrefix { get; set; }
		public int Pop3Interval { get; set; }
		public bool Pop3InlineAttachedPictures { get; set; }
		public int Pop3InlinedAttachedPicturesThumbHeight { get; set; }
		public bool ApplyContentFiltersToWeb { get; set; }
		public bool ApplyContentFiltersToRSS { get; set; }
		public bool EnableXSSUpstream { get; set; }
		public string XSSUpstreamEndpoint { get; set; }
		public string XSSUpstreamUsername { get; set; }
		public string XSSUpstreamPassword { get; set; }
		public string XSSRSSFilename { get; set; }
		public int XSSUpstreamInterval { get; set; }
		public bool Pop3DeleteAllMessages { get; set; }
		public bool Pop3LogIgnoredEmails { get; set; }
		public bool EnableReferralUrlBlackList { get; set; }
		public string ReferralUrlBlackList { get; set; }
		public string[] ReferralUrlBlackListArray { get; set; }
		public bool EnableCaptcha { get; set; }
		public bool EnableReferralUrlBlackList404s { get; set; }
		public bool EnableMovableTypeBlackList { get; set; }
		public bool EnableCrossPostFooter { get; set; }
		public string CrossPostFooter { get; set; }
		public bool ExtensionlessUrls { get; set; }
		public bool EnableTitlePermaLink { get; set; }
		public bool EnableTitlePermaLinkSpaces { get; set; }
		public bool EncryptLoginPassword { get; set; }
		public bool EnableSmtpAuthentication { get; set; }
		public string RssLanguage { get; set; }
		public bool EnableSearchHighlight { get; set; }
		public bool EnableEntryReferrals { get; set; }
		public string FeedBurnerName { get; set; }
		public bool SupressEmailAddressDisplay { get; set; }
		public bool LogBlockedReferrals { get; set; }
		public bool UseFeedSchemeForSyndication { get; set; }
		public bool EnableAutoSave { get; set; }
		public bool CommentsAllowGravatar { get; set; }
		public string CommentsGravatarNoImgPath { get; set; }
		public string CommentsGravatarSize { get; set; }
		public string CommentsGravatarBorder { get; set; }
		public string CommentsGravatarRating { get; set; }
		public bool CommentsAllowHtml { get; set; }
		public bool EnableCoComment { get; set; }
		public bool EnableSpamBlockingService { get; set; }
		public string SpamBlockingServiceApiKey { get; set; }
		//public ISpamBlockingService SpamBlockingService { get; set; }
		public bool EnableSpamModeration { get; set; }
		public bool EnableDailyReportEmail { get; set; }
		public bool EnableGoogleMaps { get; set; }
		public string GoogleMapsApiKey { get; set; }
		public bool EnableGeoRss { get; set; }
		public double DefaultLatitude { get; set; }
		public double DefaultLongitude { get; set; }
		public bool EnableDefaultLatLongForNonGeoCodedPosts { get; set; }
		public bool HtmlTidyContent { get; set; }
		public bool ResolveCommenterIP { get; set; }
		public bool AllowOpenIdComments { get; set; }
		public bool AllowOpenIdAdmin { get; set; }
		public bool BypassSpamOpenIdComment { get; set; }
		public bool AMPPagesEnabled { get; set; }
		public string RSSEndPointRewrite { get; set; }
		public bool CategoryAllEntries { get; set; }
		public string AllowedHosts { get; set; }
	}
}