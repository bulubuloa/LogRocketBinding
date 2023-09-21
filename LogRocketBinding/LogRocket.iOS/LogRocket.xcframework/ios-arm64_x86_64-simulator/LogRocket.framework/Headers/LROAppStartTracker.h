#ifndef LROAppStartTracker_h
#define LROAppStartTracker_h

@interface LROAppStartTracker : NSObject

+ (double)getInitTime;
+ (double)getFinishLaunchingTime;
+ (bool)isFirstPageLoad;
+ (void)markFirstPageLoaded;
+ (void)resetFirstPageLoad;

@end

#endif /* LROAppStartTracker_h */
