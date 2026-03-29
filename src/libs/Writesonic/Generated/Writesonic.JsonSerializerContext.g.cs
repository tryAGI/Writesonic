
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Writesonic
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Writesonic.JsonConverters.ChatSonicEngineJsonConverter),

            typeof(global::Writesonic.JsonConverters.ChatSonicEngineNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.ChatSonicLanguageJsonConverter),

            typeof(global::Writesonic.JsonConverters.ChatSonicLanguageNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.BlogIdeasEngineJsonConverter),

            typeof(global::Writesonic.JsonConverters.BlogIdeasEngineNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.BlogIdeasLanguageJsonConverter),

            typeof(global::Writesonic.JsonConverters.BlogIdeasLanguageNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.BlogIntrosEngineJsonConverter),

            typeof(global::Writesonic.JsonConverters.BlogIntrosEngineNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.BlogIntrosLanguageJsonConverter),

            typeof(global::Writesonic.JsonConverters.BlogIntrosLanguageNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.BlogOutlinesEngineJsonConverter),

            typeof(global::Writesonic.JsonConverters.BlogOutlinesEngineNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.BlogOutlinesLanguageJsonConverter),

            typeof(global::Writesonic.JsonConverters.BlogOutlinesLanguageNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.ArticleWriterV3EngineJsonConverter),

            typeof(global::Writesonic.JsonConverters.ArticleWriterV3EngineNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.ArticleWriterV3LanguageJsonConverter),

            typeof(global::Writesonic.JsonConverters.ArticleWriterV3LanguageNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.ContentRephraseEngineJsonConverter),

            typeof(global::Writesonic.JsonConverters.ContentRephraseEngineNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.ContentRephraseLanguageJsonConverter),

            typeof(global::Writesonic.JsonConverters.ContentRephraseLanguageNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.ContentShortenEngineJsonConverter),

            typeof(global::Writesonic.JsonConverters.ContentShortenEngineNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.ContentShortenLanguageJsonConverter),

            typeof(global::Writesonic.JsonConverters.ContentShortenLanguageNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.ToneChangerEngineJsonConverter),

            typeof(global::Writesonic.JsonConverters.ToneChangerEngineNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.ToneChangerLanguageJsonConverter),

            typeof(global::Writesonic.JsonConverters.ToneChangerLanguageNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.PassiveToActiveVoiceEngineJsonConverter),

            typeof(global::Writesonic.JsonConverters.PassiveToActiveVoiceEngineNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.PassiveToActiveVoiceLanguageJsonConverter),

            typeof(global::Writesonic.JsonConverters.PassiveToActiveVoiceLanguageNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.AidaFrameworkEngineJsonConverter),

            typeof(global::Writesonic.JsonConverters.AidaFrameworkEngineNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.AidaFrameworkLanguageJsonConverter),

            typeof(global::Writesonic.JsonConverters.AidaFrameworkLanguageNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.FacebookAdsEngineJsonConverter),

            typeof(global::Writesonic.JsonConverters.FacebookAdsEngineNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.FacebookAdsLanguageJsonConverter),

            typeof(global::Writesonic.JsonConverters.FacebookAdsLanguageNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.GoogleAdsEngineJsonConverter),

            typeof(global::Writesonic.JsonConverters.GoogleAdsEngineNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.GoogleAdsLanguageJsonConverter),

            typeof(global::Writesonic.JsonConverters.GoogleAdsLanguageNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.LinkedInAdsEngineJsonConverter),

            typeof(global::Writesonic.JsonConverters.LinkedInAdsEngineNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.LinkedInAdsLanguageJsonConverter),

            typeof(global::Writesonic.JsonConverters.LinkedInAdsLanguageNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.InstagramCaptionsEngineJsonConverter),

            typeof(global::Writesonic.JsonConverters.InstagramCaptionsEngineNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.InstagramCaptionsLanguageJsonConverter),

            typeof(global::Writesonic.JsonConverters.InstagramCaptionsLanguageNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.TweetsEngineJsonConverter),

            typeof(global::Writesonic.JsonConverters.TweetsEngineNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.TweetsLanguageJsonConverter),

            typeof(global::Writesonic.JsonConverters.TweetsLanguageNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.TikTokScriptsEngineJsonConverter),

            typeof(global::Writesonic.JsonConverters.TikTokScriptsEngineNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.TikTokScriptsLanguageJsonConverter),

            typeof(global::Writesonic.JsonConverters.TikTokScriptsLanguageNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.ColdEmailsEngineJsonConverter),

            typeof(global::Writesonic.JsonConverters.ColdEmailsEngineNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.ColdEmailsLanguageJsonConverter),

            typeof(global::Writesonic.JsonConverters.ColdEmailsLanguageNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.EmailSubjectLinesEngineJsonConverter),

            typeof(global::Writesonic.JsonConverters.EmailSubjectLinesEngineNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.EmailSubjectLinesLanguageJsonConverter),

            typeof(global::Writesonic.JsonConverters.EmailSubjectLinesLanguageNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.ProductDescriptionsEngineJsonConverter),

            typeof(global::Writesonic.JsonConverters.ProductDescriptionsEngineNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.ProductDescriptionsLanguageJsonConverter),

            typeof(global::Writesonic.JsonConverters.ProductDescriptionsLanguageNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.ProductNamesEngineJsonConverter),

            typeof(global::Writesonic.JsonConverters.ProductNamesEngineNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.ProductNamesLanguageJsonConverter),

            typeof(global::Writesonic.JsonConverters.ProductNamesLanguageNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.AmazonProductDescriptionsEngineJsonConverter),

            typeof(global::Writesonic.JsonConverters.AmazonProductDescriptionsEngineNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.AmazonProductDescriptionsLanguageJsonConverter),

            typeof(global::Writesonic.JsonConverters.AmazonProductDescriptionsLanguageNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.SeoMetaTagsBlogPostEngineJsonConverter),

            typeof(global::Writesonic.JsonConverters.SeoMetaTagsBlogPostEngineNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.SeoMetaTagsBlogPostLanguageJsonConverter),

            typeof(global::Writesonic.JsonConverters.SeoMetaTagsBlogPostLanguageNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.SeoMetaTagsHomepageEngineJsonConverter),

            typeof(global::Writesonic.JsonConverters.SeoMetaTagsHomepageEngineNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.SeoMetaTagsHomepageLanguageJsonConverter),

            typeof(global::Writesonic.JsonConverters.SeoMetaTagsHomepageLanguageNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.SeoMetaTagsProductPageEngineJsonConverter),

            typeof(global::Writesonic.JsonConverters.SeoMetaTagsProductPageEngineNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.SeoMetaTagsProductPageLanguageJsonConverter),

            typeof(global::Writesonic.JsonConverters.SeoMetaTagsProductPageLanguageNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.QuestionGenerationEngineJsonConverter),

            typeof(global::Writesonic.JsonConverters.QuestionGenerationEngineNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.QuestionGenerationLanguageJsonConverter),

            typeof(global::Writesonic.JsonConverters.QuestionGenerationLanguageNullableJsonConverter),

            typeof(global::Writesonic.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.ContentOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writesonic.ValidationErrorDetailItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.ValidationErrorDetailItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.HistoryEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.ChatSonicRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writesonic.HistoryEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.ChatSonicResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.GenerateImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.GenerateImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.BlogIdeasRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.BlogIntrosRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.BlogOutlinesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.ArticleWriterV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.ContentRephraseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.ContentShortenRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.ToneChangerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.AidaRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.ProductDescriptionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.FacebookAdsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.GoogleAdsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.InstagramCaptionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.TweetsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.ColdEmailsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.SubjectLinesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.SeoMetaTagsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.ActiveVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.TikTokScriptsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.LinkedInAdsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.ProductNamesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.QuestionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.AmazonProductDescriptionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.ChatSonicEngine), TypeInfoPropertyName = "ChatSonicEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.ChatSonicLanguage), TypeInfoPropertyName = "ChatSonicLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.BlogIdeasEngine), TypeInfoPropertyName = "BlogIdeasEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.BlogIdeasLanguage), TypeInfoPropertyName = "BlogIdeasLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.BlogIntrosEngine), TypeInfoPropertyName = "BlogIntrosEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.BlogIntrosLanguage), TypeInfoPropertyName = "BlogIntrosLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.BlogOutlinesEngine), TypeInfoPropertyName = "BlogOutlinesEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.BlogOutlinesLanguage), TypeInfoPropertyName = "BlogOutlinesLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.ArticleWriterV3Engine), TypeInfoPropertyName = "ArticleWriterV3Engine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.ArticleWriterV3Language), TypeInfoPropertyName = "ArticleWriterV3Language2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.ContentRephraseEngine), TypeInfoPropertyName = "ContentRephraseEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.ContentRephraseLanguage), TypeInfoPropertyName = "ContentRephraseLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.ContentShortenEngine), TypeInfoPropertyName = "ContentShortenEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.ContentShortenLanguage), TypeInfoPropertyName = "ContentShortenLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.ToneChangerEngine), TypeInfoPropertyName = "ToneChangerEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.ToneChangerLanguage), TypeInfoPropertyName = "ToneChangerLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.PassiveToActiveVoiceEngine), TypeInfoPropertyName = "PassiveToActiveVoiceEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.PassiveToActiveVoiceLanguage), TypeInfoPropertyName = "PassiveToActiveVoiceLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.AidaFrameworkEngine), TypeInfoPropertyName = "AidaFrameworkEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.AidaFrameworkLanguage), TypeInfoPropertyName = "AidaFrameworkLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.FacebookAdsEngine), TypeInfoPropertyName = "FacebookAdsEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.FacebookAdsLanguage), TypeInfoPropertyName = "FacebookAdsLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.GoogleAdsEngine), TypeInfoPropertyName = "GoogleAdsEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.GoogleAdsLanguage), TypeInfoPropertyName = "GoogleAdsLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.LinkedInAdsEngine), TypeInfoPropertyName = "LinkedInAdsEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.LinkedInAdsLanguage), TypeInfoPropertyName = "LinkedInAdsLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.InstagramCaptionsEngine), TypeInfoPropertyName = "InstagramCaptionsEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.InstagramCaptionsLanguage), TypeInfoPropertyName = "InstagramCaptionsLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.TweetsEngine), TypeInfoPropertyName = "TweetsEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.TweetsLanguage), TypeInfoPropertyName = "TweetsLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.TikTokScriptsEngine), TypeInfoPropertyName = "TikTokScriptsEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.TikTokScriptsLanguage), TypeInfoPropertyName = "TikTokScriptsLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.ColdEmailsEngine), TypeInfoPropertyName = "ColdEmailsEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.ColdEmailsLanguage), TypeInfoPropertyName = "ColdEmailsLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.EmailSubjectLinesEngine), TypeInfoPropertyName = "EmailSubjectLinesEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.EmailSubjectLinesLanguage), TypeInfoPropertyName = "EmailSubjectLinesLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.ProductDescriptionsEngine), TypeInfoPropertyName = "ProductDescriptionsEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.ProductDescriptionsLanguage), TypeInfoPropertyName = "ProductDescriptionsLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.ProductNamesEngine), TypeInfoPropertyName = "ProductNamesEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.ProductNamesLanguage), TypeInfoPropertyName = "ProductNamesLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.AmazonProductDescriptionsEngine), TypeInfoPropertyName = "AmazonProductDescriptionsEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.AmazonProductDescriptionsLanguage), TypeInfoPropertyName = "AmazonProductDescriptionsLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.SeoMetaTagsBlogPostEngine), TypeInfoPropertyName = "SeoMetaTagsBlogPostEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.SeoMetaTagsBlogPostLanguage), TypeInfoPropertyName = "SeoMetaTagsBlogPostLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.SeoMetaTagsHomepageEngine), TypeInfoPropertyName = "SeoMetaTagsHomepageEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.SeoMetaTagsHomepageLanguage), TypeInfoPropertyName = "SeoMetaTagsHomepageLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.SeoMetaTagsProductPageEngine), TypeInfoPropertyName = "SeoMetaTagsProductPageEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.SeoMetaTagsProductPageLanguage), TypeInfoPropertyName = "SeoMetaTagsProductPageLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.QuestionGenerationEngine), TypeInfoPropertyName = "QuestionGenerationEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writesonic.QuestionGenerationLanguage), TypeInfoPropertyName = "QuestionGenerationLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writesonic.ContentOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writesonic.ValidationErrorDetailItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writesonic.HistoryEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writesonic.ContentOutput>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}