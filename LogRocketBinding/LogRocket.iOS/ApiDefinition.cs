using System;
using Foundation;

namespace NativeLibrary
{
    // @interface LROConfiguration : NSObject
    [BaseType(typeof(NSObject))]
    public interface LROConfiguration
    {
        // -(instancetype _Nonnull)initWithAppID:(NSString * _Nonnull)appID __attribute__((objc_designated_initializer));
        [Export("initWithAppID:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSString appID);
    }

    // @interface LROSDK : NSObject
    [BaseType(typeof(NSObject))]
    public interface LROSDK
    {
        // + (void)initializeWithConfiguration:(LROConfiguration * _Nonnull)configuration;
        [Static]
        [Export("initializeWithConfiguration:")]
        void InitializeWithConfiguration(LROConfiguration configuration);

        // + (void)identifyWithUserID:(NSString * _Nonnull)userID userInfo:(NSDictionary<NSString *, NSString *> * _Nullable)userInfo;
        [Static]
        [Export("identifyWithUserID:userInfo:")]
        void IdentifyWithUserID(string userID, NSObject userInfo);

        // (void)tagPage:(NSString * _Nonnull)relativePage;
        [Static]
        [Export("tagPage:")]
        void TagPage(string pageName);

        // + (void)track:(LROCustomEventBuilder * _Nonnull)builder;
        [Static]
        [Export("track:")]
        void Track(LROCustomEventBuilder customEventBuilder);

        // + (void)captureMessage:(LROCaptureMessageBuilder * _Nonnull)builder;
        [Static]
        [Export("captureMessage:")]
        void CaptureMessage(LROCaptureMessageBuilder captureMessageBuilder);
    }

    // @interface LROLogger : NSObject
    [BaseType(typeof(NSObject))]
    public interface LROLogger
    {
        [Static]
        [Export("debugWithMessage:")]
        void DebugWithMessage(string message);

        [Static]
        [Export("infoWithMessage:")]
        void InfoWithMessage(string message);

        [Static]
        [Export("errorWithMessage:")]
        void ErrorWithMessage(string message);

        [Static]
        [Export("warningWithMessage:")]
        void WarningWithMessage(string message);
    }

    // @interface LROCustomEventBuilder : NSObject
    [BaseType(typeof(NSObject))]
    public interface LROCustomEventBuilder
    {
        // - (void)putString:(NSString * _Nonnull)key value:(NSString * _Nonnull)value;
        [Export("putString:value:")]
        void PutString(string key, string value);

        // - (void)putDouble:(NSString * _Nonnull)key value:(double)value;
        [Export("putDouble:value:")]
        void PutDouble(string key, double value);

        // - (void)putBool:(NSString * _Nonnull)key value:(BOOL)value;
        [Export("putBool:value:")]
        void PutBool(string key, bool value);

        [Export("init:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSString eventName);
    }

    // @interface LROCaptureMessageBuilder : NSObject
    [BaseType(typeof(NSObject))]
    public interface LROCaptureMessageBuilder
    {
        // - (void)putTagString:(NSString * _Nonnull)key value:(NSString * _Nonnull)value;
        [Export("putTagString:value:")]
        void PutTagString(string key, string value);

        // - (void)putExtraString:(NSString * _Nonnull)key value:(double)value;
        [Export("putExtraString:value:")]
        void PutExtraString(string key, string value);

        [Export("init:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSString eventName);
    }
}


