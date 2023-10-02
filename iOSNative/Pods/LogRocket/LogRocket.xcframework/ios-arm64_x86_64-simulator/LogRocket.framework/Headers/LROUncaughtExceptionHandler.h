#import <Foundation/Foundation.h>
#ifndef LROUncaughtExceptionHandler_h
#define LROUncaughtExceptionHandler_h

@interface LROUncaughtExceptionHandler : NSObject

+ (void)setSessionDetailsWithRecordingID:(NSString *)recordingID sessionID:(NSString *)sessionID appID:(NSString *)appID;

+ (void)setEnabled:(bool)isEnabled;

+ (void)updateCurrentURL:(NSString *)currentURL;

+ (void)updateSessionDetailsWithRecordingID:(NSString *)recordingID sessionID:(NSString *)sessionID;

@end

#endif /* LROUncaughtExceptionHandler_h */
