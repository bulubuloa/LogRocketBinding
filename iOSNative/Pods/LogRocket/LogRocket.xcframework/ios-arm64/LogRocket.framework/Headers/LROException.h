#ifndef LROException_h
#define LROException_h

@interface LROException : NSObject

+ (BOOL)catchException:(void(^)(void))tryBlock error:(__autoreleasing NSError **)error;

@end

#endif /* LROException_h */
