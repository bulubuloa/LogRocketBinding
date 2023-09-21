using System;
using Foundation;

namespace NativeLibrary
{
    public class Test
    {

    }

    // @interface LROConfiguration : NSObject
    [BaseType(typeof(NSObject))]
    public interface LROConfiguration
    {
        // -(instancetype _Nonnull)initWithAppID:(NSString * _Nonnull)appID __attribute__((objc_designated_initializer));
        [Export("initWithAppID:")]
        [DesignatedInitializer]
        IntPtr Constructor(string appID);
    }

    // @interface LROSDK : NSObject
    [BaseType(typeof(NSObject))]
    public interface LROSDK
    {
        [Static]
        [Export("initializeWithConfiguration:")]
        void InitializeWithConfiguration(LROConfiguration configuration);

        [Static]
        [Export("identifyWithUserID:userInfo:")]
        void IdentifyWithUserID(string userID, NSObject userInfo);
    }
}


