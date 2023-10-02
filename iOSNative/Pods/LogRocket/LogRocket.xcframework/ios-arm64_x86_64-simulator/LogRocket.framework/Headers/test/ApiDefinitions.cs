using System;
using CoreFoundation;
using CoreGraphics;
using Darwin;
using Dispatch;
using Foundation;
using LogRocket;
using ObjCRuntime;
using ObjectiveC;

namespace test
{
	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern _RuneLocale _DefaultRuneLocale;
		[Field ("_DefaultRuneLocale", "__Internal")]
		_RuneLocale _DefaultRuneLocale { get; }

		// extern _RuneLocale * _CurrentRuneLocale;
		[Field ("_CurrentRuneLocale", "__Internal")]
		unsafe _RuneLocale* _CurrentRuneLocale { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const fenv_t _FE_DFL_ENV;
		[Field ("_FE_DFL_ENV", "__Internal")]
		fenv_t _FE_DFL_ENV { get; }

		// extern const fenv_t _FE_DFL_DISABLE_DENORMS_ENV;
		[Field ("_FE_DFL_DISABLE_DENORMS_ENV", "__Internal")]
		fenv_t _FE_DFL_DISABLE_DENORMS_ENV { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int signgam;
		[Field ("signgam", "__Internal")]
		int signgam { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const char *const [32] sys_signame;
		[Field ("sys_signame", "__Internal")]
		unsafe sbyte*[] sys_signame { get; }

		// extern const char *const [32] sys_siglist;
		[Field ("sys_siglist", "__Internal")]
		unsafe sbyte*[] sys_siglist { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern FILE * __stdinp;
		[Field ("__stdinp", "__Internal")]
		unsafe FILE* __stdinp { get; }

		// extern FILE * __stdoutp;
		[Field ("__stdoutp", "__Internal")]
		unsafe FILE* __stdoutp { get; }

		// extern FILE * __stderrp;
		[Field ("__stderrp", "__Internal")]
		unsafe FILE* __stderrp { get; }

		// extern const int sys_nerr;
		[Field ("sys_nerr", "__Internal")]
		int sys_nerr { get; }

		// extern const char *const [] sys_errlist;
		[Field ("sys_errlist", "__Internal")]
		unsafe sbyte*[] sys_errlist { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int __mb_cur_max;
		[Field ("__mb_cur_max", "__Internal")]
		int __mb_cur_max { get; }

		// extern char * suboptarg;
		[Field ("suboptarg", "__Internal")]
		unsafe sbyte* suboptarg { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern char *[] tzname;
		[Field ("tzname", "__Internal")]
		unsafe sbyte*[] tzname { get; }

		// extern int getdate_err;
		[Field ("getdate_err", "__Internal")]
		int getdate_err { get; }

		// extern long timezone asm("_timezone");
		[Field ("timezone", "__Internal")]
		nint timezone { get; }

		// extern int daylight;
		[Field ("daylight", "__Internal")]
		int daylight { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const locale_t _c_locale;
		[Field ("_c_locale", "__Internal")]
		unsafe locale_t* _c_locale { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const struct in6_addr in6addr_any;
		[Field ("in6addr_any", "__Internal")]
		in6_addr in6addr_any { get; }

		// extern const struct in6_addr in6addr_loopback;
		[Field ("in6addr_loopback", "__Internal")]
		in6_addr in6addr_loopback { get; }

		// extern const struct in6_addr in6addr_nodelocal_allnodes;
		[Field ("in6addr_nodelocal_allnodes", "__Internal")]
		in6_addr in6addr_nodelocal_allnodes { get; }

		// extern const struct in6_addr in6addr_linklocal_allnodes;
		[Field ("in6addr_linklocal_allnodes", "__Internal")]
		in6_addr in6addr_linklocal_allnodes { get; }

		// extern const struct in6_addr in6addr_linklocal_allrouters;
		[Field ("in6addr_linklocal_allrouters", "__Internal")]
		in6_addr in6addr_linklocal_allrouters { get; }

		// extern const struct in6_addr in6addr_linklocal_allv2routers;
		[Field ("in6addr_linklocal_allv2routers", "__Internal")]
		in6_addr in6addr_linklocal_allv2routers { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int _libiconv_version;
		[Field ("_libiconv_version", "__Internal")]
		int _libiconv_version { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int h_errno;
		[Field ("h_errno", "__Internal")]
		int h_errno { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const security_token_t KERNEL_SECURITY_TOKEN;
		[Field ("KERNEL_SECURITY_TOKEN", "__Internal")]
		security_token_t KERNEL_SECURITY_TOKEN { get; }

		// extern const audit_token_t KERNEL_AUDIT_TOKEN;
		[Field ("KERNEL_AUDIT_TOKEN", "__Internal")]
		audit_token_t KERNEL_AUDIT_TOKEN { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern char * optarg;
		[Field ("optarg", "__Internal")]
		unsafe sbyte* optarg { get; }

		// extern int optind;
		[Field ("optind", "__Internal")]
		int optind { get; }

		// extern int opterr;
		[Field ("opterr", "__Internal")]
		int opterr { get; }

		// extern int optopt;
		[Field ("optopt", "__Internal")]
		int optopt { get; }

		// extern char * suboptarg;
		[Field ("suboptarg", "__Internal")]
		unsafe sbyte* suboptarg { get; }

		// extern int optreset;
		[Field ("optreset", "__Internal")]
		int optreset { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern vm_size_t vm_page_size;
		[Field ("vm_page_size", "__Internal")]
		UIntPtr vm_page_size { get; }

		// extern vm_size_t vm_page_mask;
		[Field ("vm_page_mask", "__Internal")]
		UIntPtr vm_page_mask { get; }

		// extern int vm_page_shift;
		[Field ("vm_page_shift", "__Internal")]
		int vm_page_shift { get; }

		// extern vm_size_t vm_kernel_page_size __attribute__((availability(ios, introduced=7.0)));
		[iOS (7, 0)]
		[Field ("vm_kernel_page_size", "__Internal")]
		UIntPtr vm_kernel_page_size { get; }

		// extern vm_size_t vm_kernel_page_mask __attribute__((availability(ios, introduced=7.0)));
		[iOS (7, 0)]
		[Field ("vm_kernel_page_mask", "__Internal")]
		UIntPtr vm_kernel_page_mask { get; }

		// extern int vm_kernel_page_shift __attribute__((availability(ios, introduced=7.0)));
		[iOS (7, 0)]
		[Field ("vm_kernel_page_shift", "__Internal")]
		int vm_kernel_page_shift { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern char * optarg;
		[Field ("optarg", "__Internal")]
		unsafe sbyte* optarg { get; }

		// extern int optind;
		[Field ("optind", "__Internal")]
		int optind { get; }

		// extern int opterr;
		[Field ("opterr", "__Internal")]
		int opterr { get; }

		// extern int optopt;
		[Field ("optopt", "__Internal")]
		int optopt { get; }

		// extern int optreset;
		[Field ("optreset", "__Internal")]
		int optreset { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NDR_record_t NDR_record;
		[Field ("NDR_record", "__Internal")]
		NDR_record_t NDR_record { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern mach_port_t mach_task_self_;
		[Field ("mach_task_self_", "__Internal")]
		uint mach_task_self_ { get; }

		// extern mach_port_t bootstrap_port;
		[Field ("bootstrap_port", "__Internal")]
		uint bootstrap_port { get; }

		// extern int (*)(const char *, va_list) vprintf_stderr_func __attribute__((format(printf, 1, 0)));
		[Field ("vprintf_stderr_func", "__Internal")]
		unsafe Func<sbyte*, sbyte*, int>* vprintf_stderr_func { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern struct port_obj_tentry * port_obj_table;
		[Field ("port_obj_table", "__Internal")]
		unsafe port_obj_tentry* port_obj_table { get; }

		// extern int port_obj_table_size;
		[Field ("port_obj_table_size", "__Internal")]
		int port_obj_table_size { get; }

		// extern NDR_record_t NDR_record;
		[Field ("NDR_record", "__Internal")]
		NDR_record_t NDR_record { get; }
	}

	// typedef void (^os_block_t)();
	delegate void os_block_t ();

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern void *[32] _NSConcreteGlobalBlock __attribute__((availability(ios, introduced=3.2)));
		[iOS (3, 2)]
		[Field ("_NSConcreteGlobalBlock", "__Internal")]
		unsafe void*[] _NSConcreteGlobalBlock { get; }

		// extern void *[32] _NSConcreteStackBlock __attribute__((availability(ios, introduced=3.2)));
		[iOS (3, 2)]
		[Field ("_NSConcreteStackBlock", "__Internal")]
		unsafe void*[] _NSConcreteStackBlock { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern struct loadavg averunnable;
		[Field ("averunnable", "__Internal")]
		loadavg averunnable { get; }
	}

	// @protocol NSObject
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface NSObject
	{
		// @required -(BOOL)isEqual:(id)object;
		[Abstract]
		[Export ("isEqual:")]
		bool IsEqual (NSObject @object);

		// @required @property (readonly) NSUInteger hash;
		[Abstract]
		[Export ("hash")]
		nuint Hash { get; }

		// @required @property (readonly) Class superclass;
		[Abstract]
		[Export ("superclass")]
		Class Superclass { get; }

		// @required -(Class)class __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[Abstract]
		[Export ("class")]
		[Verify (MethodToProperty)]
		Class Class { get; }

		// @required -(instancetype)self;
		[Abstract]
		[Export ("self")]
		NSObject Self ();

		// @required -(id)performSelector:(SEL)aSelector;
		[Abstract]
		[Export ("performSelector:")]
		NSObject PerformSelector (Selector aSelector);

		// @required -(id)performSelector:(SEL)aSelector withObject:(id)object;
		[Abstract]
		[Export ("performSelector:withObject:")]
		NSObject PerformSelector (Selector aSelector, NSObject @object);

		// @required -(id)performSelector:(SEL)aSelector withObject:(id)object1 withObject:(id)object2;
		[Abstract]
		[Export ("performSelector:withObject:withObject:")]
		NSObject PerformSelector (Selector aSelector, NSObject object1, NSObject object2);

		// @required -(BOOL)isProxy;
		[Abstract]
		[Export ("isProxy")]
		[Verify (MethodToProperty)]
		bool IsProxy { get; }

		// @required -(BOOL)isKindOfClass:(Class)aClass;
		[Abstract]
		[Export ("isKindOfClass:")]
		bool IsKindOfClass (Class aClass);

		// @required -(BOOL)isMemberOfClass:(Class)aClass;
		[Abstract]
		[Export ("isMemberOfClass:")]
		bool IsMemberOfClass (Class aClass);

		// @required -(BOOL)conformsToProtocol:(Protocol *)aProtocol;
		[Abstract]
		[Export ("conformsToProtocol:")]
		bool ConformsToProtocol (Protocol aProtocol);

		// @required -(BOOL)respondsToSelector:(SEL)aSelector;
		[Abstract]
		[Export ("respondsToSelector:")]
		bool RespondsToSelector (Selector aSelector);

		// @required -(instancetype)retain;
		[Abstract]
		[Export ("retain")]
		NSObject Retain ();

		// @required -(void)release;
		[Abstract]
		[Export ("release")]
		void Release ();

		// @required -(instancetype)autorelease;
		[Abstract]
		[Export ("autorelease")]
		NSObject Autorelease ();

		// @required -(NSUInteger)retainCount;
		[Abstract]
		[Export ("retainCount")]
		[Verify (MethodToProperty)]
		nuint RetainCount { get; }

		// @required -(struct _NSZone *)zone;
		[Abstract]
		[Export ("zone")]
		[Verify (MethodToProperty)]
		unsafe _NSZone* Zone { get; }

		// @required @property (readonly, copy) NSString * description;
		[Abstract]
		[Export ("description")]
		string Description { get; }

		// @optional @property (readonly, copy) NSString * debugDescription;
		[Export ("debugDescription")]
		string DebugDescription { get; }
	}

	// @interface NSObject <NSObject>
	[Watch (1,0), TV (9,0), Mac (10,0), iOS (2,0)]
	[BaseType (typeof(NSObject))]
	interface NSObject
	{
		// +(void)load;
		[Static]
		[Export ("load")]
		void Load ();

		// +(void)initialize;
		[Static]
		[Export ("initialize")]
		void Initialize ();

		// +(instancetype)new __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[Static]
		[Export ("new")]
		NSObject New ();

		// +(instancetype)allocWithZone:(struct _NSZone *)zone __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[Static]
		[Export ("allocWithZone:")]
		unsafe NSObject AllocWithZone (_NSZone* zone);

		// +(instancetype)alloc __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[Static]
		[Export ("alloc")]
		NSObject Alloc ();

		// -(void)dealloc __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[Export ("dealloc")]
		void Dealloc ();

		// -(void)finalize __attribute__((deprecated("Objective-C garbage collection is no longer supported")));
		[Export ("finalize")]
		void Finalize ();

		// -(id)copy;
		[Export ("copy")]
		[Verify (MethodToProperty)]
		NSObject Copy { get; }

		// -(id)mutableCopy;
		[Export ("mutableCopy")]
		[Verify (MethodToProperty)]
		NSObject MutableCopy { get; }

		// +(id)copyWithZone:(struct _NSZone *)zone;
		[Static]
		[Export ("copyWithZone:")]
		unsafe NSObject CopyWithZone (_NSZone* zone);

		// +(id)mutableCopyWithZone:(struct _NSZone *)zone;
		[Static]
		[Export ("mutableCopyWithZone:")]
		unsafe NSObject MutableCopyWithZone (_NSZone* zone);

		// +(BOOL)instancesRespondToSelector:(SEL)aSelector;
		[Static]
		[Export ("instancesRespondToSelector:")]
		bool InstancesRespondToSelector (Selector aSelector);

		// +(BOOL)conformsToProtocol:(Protocol *)protocol;
		[Static]
		[Export ("conformsToProtocol:")]
		bool ConformsToProtocol (Protocol protocol);

		// -(IMP)methodForSelector:(SEL)aSelector;
		[Export ("methodForSelector:")]
		unsafe IMP* MethodForSelector (Selector aSelector);

		// +(IMP)instanceMethodForSelector:(SEL)aSelector;
		[Static]
		[Export ("instanceMethodForSelector:")]
		unsafe IMP* InstanceMethodForSelector (Selector aSelector);

		// -(void)doesNotRecognizeSelector:(SEL)aSelector;
		[Export ("doesNotRecognizeSelector:")]
		void DoesNotRecognizeSelector (Selector aSelector);

		// -(id)forwardingTargetForSelector:(SEL)aSelector __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=1.0)));
		[Watch (1,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[Export ("forwardingTargetForSelector:")]
		NSObject ForwardingTargetForSelector (Selector aSelector);

		// -(void)forwardInvocation:(NSInvocation *)anInvocation __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[Export ("forwardInvocation:")]
		void ForwardInvocation (NSInvocation anInvocation);

		// -(NSMethodSignature *)methodSignatureForSelector:(SEL)aSelector __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[Export ("methodSignatureForSelector:")]
		NSMethodSignature MethodSignatureForSelector (Selector aSelector);

		// +(NSMethodSignature *)instanceMethodSignatureForSelector:(SEL)aSelector __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[Static]
		[Export ("instanceMethodSignatureForSelector:")]
		NSMethodSignature InstanceMethodSignatureForSelector (Selector aSelector);

		// +(BOOL)isSubclassOfClass:(Class)aClass;
		[Static]
		[Export ("isSubclassOfClass:")]
		bool IsSubclassOfClass (Class aClass);

		// +(BOOL)resolveClassMethod:(SEL)sel __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=1.0)));
		[Watch (1,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[Static]
		[Export ("resolveClassMethod:")]
		bool ResolveClassMethod (Selector sel);

		// +(BOOL)resolveInstanceMethod:(SEL)sel __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=1.0)));
		[Watch (1,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[Static]
		[Export ("resolveInstanceMethod:")]
		bool ResolveInstanceMethod (Selector sel);

		// +(NSUInteger)hash;
		[Static]
		[Export ("hash")]
		[Verify (MethodToProperty)]
		nuint Hash { get; }

		// +(Class)superclass;
		[Static]
		[Export ("superclass")]
		[Verify (MethodToProperty)]
		Class Superclass { get; }

		// +(Class)class __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[Static]
		[Export ("class")]
		[Verify (MethodToProperty)]
		Class Class { get; }

		// +(NSString *)description;
		[Static]
		[Export ("description")]
		[Verify (MethodToProperty)]
		string Description { get; }

		// +(NSString *)debugDescription;
		[Static]
		[Export ("debugDescription")]
		[Verify (MethodToProperty)]
		string DebugDescription { get; }
	}

	// @interface OS_object : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface OS_object
	{
	}

	// @interface OS_os_workgroup : OS_object
	[BaseType (typeof(OS_object))]
	[DisableDefaultCtor]
	interface OS_os_workgroup
	{
	}

	// @protocol OS_os_workgroup_interval
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface OS_os_workgroup_interval
	{
	}

	// @interface OS_os_workgroup_interval : OS_os_workgroup <OS_os_workgroup_interval>
	[BaseType (typeof(OS_os_workgroup))]
	[DisableDefaultCtor]
	interface OS_os_workgroup_interval : IOS_os_workgroup_interval
	{
	}

	// @protocol OS_os_workgroup_parallel
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface OS_os_workgroup_parallel
	{
	}

	// @interface OS_os_workgroup_parallel : OS_os_workgroup <OS_os_workgroup_parallel>
	[BaseType (typeof(OS_os_workgroup))]
	[DisableDefaultCtor]
	interface OS_os_workgroup_parallel : IOS_os_workgroup_parallel
	{
	}

	// @protocol OS_dispatch_object <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface OS_dispatch_object
	{
	}

	// typedef void (^dispatch_block_t)();
	delegate void dispatch_block_t ();

	// @protocol OS_dispatch_queue <OS_dispatch_object>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface OS_dispatch_queue : IOS_dispatch_object
	{
	}

	// @protocol OS_dispatch_queue_global <OS_dispatch_queue>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface OS_dispatch_queue_global : IOS_dispatch_queue
	{
	}

	// @protocol OS_dispatch_queue_serial <OS_dispatch_queue>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface OS_dispatch_queue_serial : IOS_dispatch_queue
	{
	}

	// @protocol OS_dispatch_queue_main <OS_dispatch_queue_serial>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface OS_dispatch_queue_main : IOS_dispatch_queue_serial
	{
	}

	// @protocol OS_dispatch_queue_concurrent <OS_dispatch_queue>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface OS_dispatch_queue_concurrent : IOS_dispatch_queue
	{
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern struct dispatch_queue_s _dispatch_main_q __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default")));
		[Mac (10, 6), iOS (4, 0)]
		[Field ("_dispatch_main_q", "__Internal")]
		dispatch_queue_s _dispatch_main_q { get; }
	}

	// @protocol OS_dispatch_queue_attr <OS_dispatch_object>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface OS_dispatch_queue_attr : IOS_dispatch_object
	{
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern struct dispatch_queue_attr_s _dispatch_queue_attr_concurrent __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=4.3))) __attribute__((visibility("default")));
		[Mac (10, 7), iOS (4, 3)]
		[Field ("_dispatch_queue_attr_concurrent", "__Internal")]
		dispatch_queue_attr_s _dispatch_queue_attr_concurrent { get; }
	}

	// @protocol OS_dispatch_source <OS_dispatch_object>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface OS_dispatch_source : IOS_dispatch_object
	{
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const struct dispatch_source_type_s _dispatch_source_type_data_add __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default")));
		[Mac (10, 6), iOS (4, 0)]
		[Field ("_dispatch_source_type_data_add", "__Internal")]
		dispatch_source_type_s _dispatch_source_type_data_add { get; }

		// extern const struct dispatch_source_type_s _dispatch_source_type_data_or __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default")));
		[Mac (10, 6), iOS (4, 0)]
		[Field ("_dispatch_source_type_data_or", "__Internal")]
		dispatch_source_type_s _dispatch_source_type_data_or { get; }

		// extern const struct dispatch_source_type_s _dispatch_source_type_data_replace __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0))) __attribute__((visibility("default")));
		[Watch (4, 0), TV (11, 0), Mac (10, 13), iOS (11, 0)]
		[Field ("_dispatch_source_type_data_replace", "__Internal")]
		dispatch_source_type_s _dispatch_source_type_data_replace { get; }

		// extern const struct dispatch_source_type_s _dispatch_source_type_mach_send __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default")));
		[Mac (10, 6), iOS (4, 0)]
		[Field ("_dispatch_source_type_mach_send", "__Internal")]
		dispatch_source_type_s _dispatch_source_type_mach_send { get; }

		// extern const struct dispatch_source_type_s _dispatch_source_type_mach_recv __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default")));
		[Mac (10, 6), iOS (4, 0)]
		[Field ("_dispatch_source_type_mach_recv", "__Internal")]
		dispatch_source_type_s _dispatch_source_type_mach_recv { get; }

		// extern const struct dispatch_source_type_s _dispatch_source_type_memorypressure __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=8.0))) __attribute__((visibility("default")));
		[Mac (10, 9), iOS (8, 0)]
		[Field ("_dispatch_source_type_memorypressure", "__Internal")]
		dispatch_source_type_s _dispatch_source_type_memorypressure { get; }

		// extern const struct dispatch_source_type_s _dispatch_source_type_proc __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default")));
		[Mac (10, 6), iOS (4, 0)]
		[Field ("_dispatch_source_type_proc", "__Internal")]
		dispatch_source_type_s _dispatch_source_type_proc { get; }

		// extern const struct dispatch_source_type_s _dispatch_source_type_read __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default")));
		[Mac (10, 6), iOS (4, 0)]
		[Field ("_dispatch_source_type_read", "__Internal")]
		dispatch_source_type_s _dispatch_source_type_read { get; }

		// extern const struct dispatch_source_type_s _dispatch_source_type_signal __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default")));
		[Mac (10, 6), iOS (4, 0)]
		[Field ("_dispatch_source_type_signal", "__Internal")]
		dispatch_source_type_s _dispatch_source_type_signal { get; }

		// extern const struct dispatch_source_type_s _dispatch_source_type_timer __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default")));
		[Mac (10, 6), iOS (4, 0)]
		[Field ("_dispatch_source_type_timer", "__Internal")]
		dispatch_source_type_s _dispatch_source_type_timer { get; }

		// extern const struct dispatch_source_type_s _dispatch_source_type_vnode __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default")));
		[Mac (10, 6), iOS (4, 0)]
		[Field ("_dispatch_source_type_vnode", "__Internal")]
		dispatch_source_type_s _dispatch_source_type_vnode { get; }

		// extern const struct dispatch_source_type_s _dispatch_source_type_write __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default")));
		[Mac (10, 6), iOS (4, 0)]
		[Field ("_dispatch_source_type_write", "__Internal")]
		dispatch_source_type_s _dispatch_source_type_write { get; }
	}

	// @protocol OS_dispatch_group <OS_dispatch_object>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface OS_dispatch_group : IOS_dispatch_object
	{
	}

	// @protocol OS_dispatch_semaphore <OS_dispatch_object>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface OS_dispatch_semaphore : IOS_dispatch_object
	{
	}

	// @protocol OS_dispatch_data <OS_dispatch_object>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface OS_dispatch_data : IOS_dispatch_object
	{
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern struct dispatch_data_s _dispatch_data_empty __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((visibility("default")));
		[Mac (10, 7), iOS (5, 0)]
		[Field ("_dispatch_data_empty", "__Internal")]
		dispatch_data_s _dispatch_data_empty { get; }

		// extern const dispatch_block_t _Nonnull _dispatch_data_destructor_free __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((visibility("default")));
		[Mac (10, 7), iOS (5, 0)]
		[Field ("_dispatch_data_destructor_free", "__Internal")]
		dispatch_block_t _dispatch_data_destructor_free { get; }

		// extern const dispatch_block_t _Nonnull _dispatch_data_destructor_munmap __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((visibility("default")));
		[Mac (10, 9), iOS (7, 0)]
		[Field ("_dispatch_data_destructor_munmap", "__Internal")]
		dispatch_block_t _dispatch_data_destructor_munmap { get; }
	}

	// typedef _Bool (^dispatch_data_applier_t)(dispatch_data_t _Nonnull, size_t, const void * _Nonnull, size_t);
	unsafe delegate bool dispatch_data_applier_t (OS_dispatch_data arg0, nuint arg1, void* arg2, nuint arg3);

	// @protocol OS_dispatch_io <OS_dispatch_object>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface OS_dispatch_io : IOS_dispatch_object
	{
	}

	// typedef void (^dispatch_io_handler_t)(_Bool, dispatch_data_t _Nullable, int);
	delegate void dispatch_io_handler_t (bool arg0, [NullAllowed] OS_dispatch_data arg1, int arg2);

	// @protocol OS_dispatch_workloop <OS_dispatch_queue>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface OS_dispatch_workloop : IOS_dispatch_queue
	{
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double kCFCoreFoundationVersionNumber;
		[Field ("kCFCoreFoundationVersionNumber", "__Internal")]
		double kCFCoreFoundationVersionNumber { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFNullRef kCFNull;
		[Field ("kCFNull", "__Internal")]
		unsafe CFNullRef* kCFNull { get; }

		// extern const CFAllocatorRef kCFAllocatorDefault;
		[Field ("kCFAllocatorDefault", "__Internal")]
		unsafe CFAllocatorRef* kCFAllocatorDefault { get; }

		// extern const CFAllocatorRef kCFAllocatorSystemDefault;
		[Field ("kCFAllocatorSystemDefault", "__Internal")]
		unsafe CFAllocatorRef* kCFAllocatorSystemDefault { get; }

		// extern const CFAllocatorRef kCFAllocatorMalloc;
		[Field ("kCFAllocatorMalloc", "__Internal")]
		unsafe CFAllocatorRef* kCFAllocatorMalloc { get; }

		// extern const CFAllocatorRef kCFAllocatorMallocZone;
		[Field ("kCFAllocatorMallocZone", "__Internal")]
		unsafe CFAllocatorRef* kCFAllocatorMallocZone { get; }

		// extern const CFAllocatorRef kCFAllocatorNull;
		[Field ("kCFAllocatorNull", "__Internal")]
		unsafe CFAllocatorRef* kCFAllocatorNull { get; }

		// extern const CFAllocatorRef kCFAllocatorUseContext;
		[Field ("kCFAllocatorUseContext", "__Internal")]
		unsafe CFAllocatorRef* kCFAllocatorUseContext { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFArrayCallBacks kCFTypeArrayCallBacks;
		[Field ("kCFTypeArrayCallBacks", "__Internal")]
		CFArrayCallBacks kCFTypeArrayCallBacks { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFBagCallBacks kCFTypeBagCallBacks;
		[Field ("kCFTypeBagCallBacks", "__Internal")]
		CFBagCallBacks kCFTypeBagCallBacks { get; }

		// extern const CFBagCallBacks kCFCopyStringBagCallBacks;
		[Field ("kCFCopyStringBagCallBacks", "__Internal")]
		CFBagCallBacks kCFCopyStringBagCallBacks { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFBinaryHeapCallBacks kCFStringBinaryHeapCallBacks;
		[Field ("kCFStringBinaryHeapCallBacks", "__Internal")]
		CFBinaryHeapCallBacks kCFStringBinaryHeapCallBacks { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFDictionaryKeyCallBacks kCFTypeDictionaryKeyCallBacks;
		[Field ("kCFTypeDictionaryKeyCallBacks", "__Internal")]
		CFDictionaryKeyCallBacks kCFTypeDictionaryKeyCallBacks { get; }

		// extern const CFDictionaryKeyCallBacks kCFCopyStringDictionaryKeyCallBacks;
		[Field ("kCFCopyStringDictionaryKeyCallBacks", "__Internal")]
		CFDictionaryKeyCallBacks kCFCopyStringDictionaryKeyCallBacks { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFDictionaryValueCallBacks kCFTypeDictionaryValueCallBacks;
		[Field ("kCFTypeDictionaryValueCallBacks", "__Internal")]
		CFDictionaryValueCallBacks kCFTypeDictionaryValueCallBacks { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFNotificationName kCFLocaleCurrentLocaleDidChangeNotification __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFLocaleCurrentLocaleDidChangeNotification", "__Internal")]
		unsafe CFNotificationName* kCFLocaleCurrentLocaleDidChangeNotification { get; }

		// extern const CFLocaleKey kCFLocaleIdentifier;
		[Field ("kCFLocaleIdentifier", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleIdentifier { get; }

		// extern const CFLocaleKey kCFLocaleLanguageCode;
		[Field ("kCFLocaleLanguageCode", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleLanguageCode { get; }

		// extern const CFLocaleKey kCFLocaleCountryCode;
		[Field ("kCFLocaleCountryCode", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleCountryCode { get; }

		// extern const CFLocaleKey kCFLocaleScriptCode;
		[Field ("kCFLocaleScriptCode", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleScriptCode { get; }

		// extern const CFLocaleKey kCFLocaleVariantCode;
		[Field ("kCFLocaleVariantCode", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleVariantCode { get; }

		// extern const CFLocaleKey kCFLocaleExemplarCharacterSet;
		[Field ("kCFLocaleExemplarCharacterSet", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleExemplarCharacterSet { get; }

		// extern const CFLocaleKey kCFLocaleCalendarIdentifier;
		[Field ("kCFLocaleCalendarIdentifier", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleCalendarIdentifier { get; }

		// extern const CFLocaleKey kCFLocaleCalendar;
		[Field ("kCFLocaleCalendar", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleCalendar { get; }

		// extern const CFLocaleKey kCFLocaleCollationIdentifier;
		[Field ("kCFLocaleCollationIdentifier", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleCollationIdentifier { get; }

		// extern const CFLocaleKey kCFLocaleUsesMetricSystem;
		[Field ("kCFLocaleUsesMetricSystem", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleUsesMetricSystem { get; }

		// extern const CFLocaleKey kCFLocaleMeasurementSystem;
		[Field ("kCFLocaleMeasurementSystem", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleMeasurementSystem { get; }

		// extern const CFLocaleKey kCFLocaleDecimalSeparator;
		[Field ("kCFLocaleDecimalSeparator", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleDecimalSeparator { get; }

		// extern const CFLocaleKey kCFLocaleGroupingSeparator;
		[Field ("kCFLocaleGroupingSeparator", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleGroupingSeparator { get; }

		// extern const CFLocaleKey kCFLocaleCurrencySymbol;
		[Field ("kCFLocaleCurrencySymbol", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleCurrencySymbol { get; }

		// extern const CFLocaleKey kCFLocaleCurrencyCode;
		[Field ("kCFLocaleCurrencyCode", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleCurrencyCode { get; }

		// extern const CFLocaleKey kCFLocaleCollatorIdentifier __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFLocaleCollatorIdentifier", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleCollatorIdentifier { get; }

		// extern const CFLocaleKey kCFLocaleQuotationBeginDelimiterKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFLocaleQuotationBeginDelimiterKey", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleQuotationBeginDelimiterKey { get; }

		// extern const CFLocaleKey kCFLocaleQuotationEndDelimiterKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFLocaleQuotationEndDelimiterKey", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleQuotationEndDelimiterKey { get; }

		// extern const CFLocaleKey kCFLocaleAlternateQuotationBeginDelimiterKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFLocaleAlternateQuotationBeginDelimiterKey", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleAlternateQuotationBeginDelimiterKey { get; }

		// extern const CFLocaleKey kCFLocaleAlternateQuotationEndDelimiterKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFLocaleAlternateQuotationEndDelimiterKey", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleAlternateQuotationEndDelimiterKey { get; }

		// extern const CFCalendarIdentifier kCFGregorianCalendar;
		[Field ("kCFGregorianCalendar", "__Internal")]
		unsafe CFCalendarIdentifier* kCFGregorianCalendar { get; }

		// extern const CFCalendarIdentifier kCFBuddhistCalendar;
		[Field ("kCFBuddhistCalendar", "__Internal")]
		unsafe CFCalendarIdentifier* kCFBuddhistCalendar { get; }

		// extern const CFCalendarIdentifier kCFChineseCalendar;
		[Field ("kCFChineseCalendar", "__Internal")]
		unsafe CFCalendarIdentifier* kCFChineseCalendar { get; }

		// extern const CFCalendarIdentifier kCFHebrewCalendar;
		[Field ("kCFHebrewCalendar", "__Internal")]
		unsafe CFCalendarIdentifier* kCFHebrewCalendar { get; }

		// extern const CFCalendarIdentifier kCFIslamicCalendar;
		[Field ("kCFIslamicCalendar", "__Internal")]
		unsafe CFCalendarIdentifier* kCFIslamicCalendar { get; }

		// extern const CFCalendarIdentifier kCFIslamicCivilCalendar;
		[Field ("kCFIslamicCivilCalendar", "__Internal")]
		unsafe CFCalendarIdentifier* kCFIslamicCivilCalendar { get; }

		// extern const CFCalendarIdentifier kCFJapaneseCalendar;
		[Field ("kCFJapaneseCalendar", "__Internal")]
		unsafe CFCalendarIdentifier* kCFJapaneseCalendar { get; }

		// extern const CFCalendarIdentifier kCFRepublicOfChinaCalendar __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFRepublicOfChinaCalendar", "__Internal")]
		unsafe CFCalendarIdentifier* kCFRepublicOfChinaCalendar { get; }

		// extern const CFCalendarIdentifier kCFPersianCalendar __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFPersianCalendar", "__Internal")]
		unsafe CFCalendarIdentifier* kCFPersianCalendar { get; }

		// extern const CFCalendarIdentifier kCFIndianCalendar __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFIndianCalendar", "__Internal")]
		unsafe CFCalendarIdentifier* kCFIndianCalendar { get; }

		// extern const CFCalendarIdentifier kCFISO8601Calendar __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFISO8601Calendar", "__Internal")]
		unsafe CFCalendarIdentifier* kCFISO8601Calendar { get; }

		// extern const CFCalendarIdentifier kCFIslamicTabularCalendar __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 10), iOS (8, 0)]
		[Field ("kCFIslamicTabularCalendar", "__Internal")]
		unsafe CFCalendarIdentifier* kCFIslamicTabularCalendar { get; }

		// extern const CFCalendarIdentifier kCFIslamicUmmAlQuraCalendar __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 10), iOS (8, 0)]
		[Field ("kCFIslamicUmmAlQuraCalendar", "__Internal")]
		unsafe CFCalendarIdentifier* kCFIslamicUmmAlQuraCalendar { get; }

		// extern const CFTimeInterval kCFAbsoluteTimeIntervalSince1970;
		[Field ("kCFAbsoluteTimeIntervalSince1970", "__Internal")]
		double kCFAbsoluteTimeIntervalSince1970 { get; }

		// extern const CFTimeInterval kCFAbsoluteTimeIntervalSince1904;
		[Field ("kCFAbsoluteTimeIntervalSince1904", "__Internal")]
		double kCFAbsoluteTimeIntervalSince1904 { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFErrorDomain kCFErrorDomainPOSIX __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFErrorDomainPOSIX", "__Internal")]
		unsafe CFErrorDomain* kCFErrorDomainPOSIX { get; }

		// extern const CFErrorDomain kCFErrorDomainOSStatus __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFErrorDomainOSStatus", "__Internal")]
		unsafe CFErrorDomain* kCFErrorDomainOSStatus { get; }

		// extern const CFErrorDomain kCFErrorDomainMach __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFErrorDomainMach", "__Internal")]
		unsafe CFErrorDomain* kCFErrorDomainMach { get; }

		// extern const CFErrorDomain kCFErrorDomainCocoa __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFErrorDomainCocoa", "__Internal")]
		unsafe CFErrorDomain* kCFErrorDomainCocoa { get; }

		// extern const CFStringRef kCFErrorLocalizedDescriptionKey __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFErrorLocalizedDescriptionKey", "__Internal")]
		unsafe CFStringRef* kCFErrorLocalizedDescriptionKey { get; }

		// extern const CFStringRef kCFErrorLocalizedFailureKey __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0))) __attribute__((availability(tvos, introduced=11.0)));
		[Watch (4, 0), TV (11, 0), Mac (10, 13), iOS (11, 0)]
		[Field ("kCFErrorLocalizedFailureKey", "__Internal")]
		unsafe CFStringRef* kCFErrorLocalizedFailureKey { get; }

		// extern const CFStringRef kCFErrorLocalizedFailureReasonKey __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFErrorLocalizedFailureReasonKey", "__Internal")]
		unsafe CFStringRef* kCFErrorLocalizedFailureReasonKey { get; }

		// extern const CFStringRef kCFErrorLocalizedRecoverySuggestionKey __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFErrorLocalizedRecoverySuggestionKey", "__Internal")]
		unsafe CFStringRef* kCFErrorLocalizedRecoverySuggestionKey { get; }

		// extern const CFStringRef kCFErrorDescriptionKey __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFErrorDescriptionKey", "__Internal")]
		unsafe CFStringRef* kCFErrorDescriptionKey { get; }

		// extern const CFStringRef kCFErrorUnderlyingErrorKey __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFErrorUnderlyingErrorKey", "__Internal")]
		unsafe CFStringRef* kCFErrorUnderlyingErrorKey { get; }

		// extern const CFStringRef kCFErrorURLKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFErrorURLKey", "__Internal")]
		unsafe CFStringRef* kCFErrorURLKey { get; }

		// extern const CFStringRef kCFErrorFilePathKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFErrorFilePathKey", "__Internal")]
		unsafe CFStringRef* kCFErrorFilePathKey { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef kCFStringTransformStripCombiningMarks;
		[Field ("kCFStringTransformStripCombiningMarks", "__Internal")]
		unsafe CFStringRef* kCFStringTransformStripCombiningMarks { get; }

		// extern const CFStringRef kCFStringTransformToLatin;
		[Field ("kCFStringTransformToLatin", "__Internal")]
		unsafe CFStringRef* kCFStringTransformToLatin { get; }

		// extern const CFStringRef kCFStringTransformFullwidthHalfwidth;
		[Field ("kCFStringTransformFullwidthHalfwidth", "__Internal")]
		unsafe CFStringRef* kCFStringTransformFullwidthHalfwidth { get; }

		// extern const CFStringRef kCFStringTransformLatinKatakana;
		[Field ("kCFStringTransformLatinKatakana", "__Internal")]
		unsafe CFStringRef* kCFStringTransformLatinKatakana { get; }

		// extern const CFStringRef kCFStringTransformLatinHiragana;
		[Field ("kCFStringTransformLatinHiragana", "__Internal")]
		unsafe CFStringRef* kCFStringTransformLatinHiragana { get; }

		// extern const CFStringRef kCFStringTransformHiraganaKatakana;
		[Field ("kCFStringTransformHiraganaKatakana", "__Internal")]
		unsafe CFStringRef* kCFStringTransformHiraganaKatakana { get; }

		// extern const CFStringRef kCFStringTransformMandarinLatin;
		[Field ("kCFStringTransformMandarinLatin", "__Internal")]
		unsafe CFStringRef* kCFStringTransformMandarinLatin { get; }

		// extern const CFStringRef kCFStringTransformLatinHangul;
		[Field ("kCFStringTransformLatinHangul", "__Internal")]
		unsafe CFStringRef* kCFStringTransformLatinHangul { get; }

		// extern const CFStringRef kCFStringTransformLatinArabic;
		[Field ("kCFStringTransformLatinArabic", "__Internal")]
		unsafe CFStringRef* kCFStringTransformLatinArabic { get; }

		// extern const CFStringRef kCFStringTransformLatinHebrew;
		[Field ("kCFStringTransformLatinHebrew", "__Internal")]
		unsafe CFStringRef* kCFStringTransformLatinHebrew { get; }

		// extern const CFStringRef kCFStringTransformLatinThai;
		[Field ("kCFStringTransformLatinThai", "__Internal")]
		unsafe CFStringRef* kCFStringTransformLatinThai { get; }

		// extern const CFStringRef kCFStringTransformLatinCyrillic;
		[Field ("kCFStringTransformLatinCyrillic", "__Internal")]
		unsafe CFStringRef* kCFStringTransformLatinCyrillic { get; }

		// extern const CFStringRef kCFStringTransformLatinGreek;
		[Field ("kCFStringTransformLatinGreek", "__Internal")]
		unsafe CFStringRef* kCFStringTransformLatinGreek { get; }

		// extern const CFStringRef kCFStringTransformToXMLHex;
		[Field ("kCFStringTransformToXMLHex", "__Internal")]
		unsafe CFStringRef* kCFStringTransformToXMLHex { get; }

		// extern const CFStringRef kCFStringTransformToUnicodeName;
		[Field ("kCFStringTransformToUnicodeName", "__Internal")]
		unsafe CFStringRef* kCFStringTransformToUnicodeName { get; }

		// extern const CFStringRef kCFStringTransformStripDiacritics __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFStringTransformStripDiacritics", "__Internal")]
		unsafe CFStringRef* kCFStringTransformStripDiacritics { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFNotificationName kCFTimeZoneSystemTimeZoneDidChangeNotification __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFTimeZoneSystemTimeZoneDidChangeNotification", "__Internal")]
		unsafe CFNotificationName* kCFTimeZoneSystemTimeZoneDidChangeNotification { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFDateFormatterKey kCFDateFormatterIsLenient;
		[Field ("kCFDateFormatterIsLenient", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterIsLenient { get; }

		// extern const CFDateFormatterKey kCFDateFormatterTimeZone;
		[Field ("kCFDateFormatterTimeZone", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterTimeZone { get; }

		// extern const CFDateFormatterKey kCFDateFormatterCalendarName;
		[Field ("kCFDateFormatterCalendarName", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterCalendarName { get; }

		// extern const CFDateFormatterKey kCFDateFormatterDefaultFormat;
		[Field ("kCFDateFormatterDefaultFormat", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterDefaultFormat { get; }

		// extern const CFDateFormatterKey kCFDateFormatterTwoDigitStartDate;
		[Field ("kCFDateFormatterTwoDigitStartDate", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterTwoDigitStartDate { get; }

		// extern const CFDateFormatterKey kCFDateFormatterDefaultDate;
		[Field ("kCFDateFormatterDefaultDate", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterDefaultDate { get; }

		// extern const CFDateFormatterKey kCFDateFormatterCalendar;
		[Field ("kCFDateFormatterCalendar", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterCalendar { get; }

		// extern const CFDateFormatterKey kCFDateFormatterEraSymbols;
		[Field ("kCFDateFormatterEraSymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterEraSymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterMonthSymbols;
		[Field ("kCFDateFormatterMonthSymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterMonthSymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterShortMonthSymbols;
		[Field ("kCFDateFormatterShortMonthSymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterShortMonthSymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterWeekdaySymbols;
		[Field ("kCFDateFormatterWeekdaySymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterWeekdaySymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterShortWeekdaySymbols;
		[Field ("kCFDateFormatterShortWeekdaySymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterShortWeekdaySymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterAMSymbol;
		[Field ("kCFDateFormatterAMSymbol", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterAMSymbol { get; }

		// extern const CFDateFormatterKey kCFDateFormatterPMSymbol;
		[Field ("kCFDateFormatterPMSymbol", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterPMSymbol { get; }

		// extern const CFDateFormatterKey kCFDateFormatterLongEraSymbols __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFDateFormatterLongEraSymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterLongEraSymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterVeryShortMonthSymbols __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFDateFormatterVeryShortMonthSymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterVeryShortMonthSymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterStandaloneMonthSymbols __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFDateFormatterStandaloneMonthSymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterStandaloneMonthSymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterShortStandaloneMonthSymbols __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFDateFormatterShortStandaloneMonthSymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterShortStandaloneMonthSymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterVeryShortStandaloneMonthSymbols __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFDateFormatterVeryShortStandaloneMonthSymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterVeryShortStandaloneMonthSymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterVeryShortWeekdaySymbols __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFDateFormatterVeryShortWeekdaySymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterVeryShortWeekdaySymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterStandaloneWeekdaySymbols __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFDateFormatterStandaloneWeekdaySymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterStandaloneWeekdaySymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterShortStandaloneWeekdaySymbols __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFDateFormatterShortStandaloneWeekdaySymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterShortStandaloneWeekdaySymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterVeryShortStandaloneWeekdaySymbols __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFDateFormatterVeryShortStandaloneWeekdaySymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterVeryShortStandaloneWeekdaySymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterQuarterSymbols __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFDateFormatterQuarterSymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterQuarterSymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterShortQuarterSymbols __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFDateFormatterShortQuarterSymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterShortQuarterSymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterStandaloneQuarterSymbols __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFDateFormatterStandaloneQuarterSymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterStandaloneQuarterSymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterShortStandaloneQuarterSymbols __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFDateFormatterShortStandaloneQuarterSymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterShortStandaloneQuarterSymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterGregorianStartDate __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFDateFormatterGregorianStartDate", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterGregorianStartDate { get; }

		// extern const CFDateFormatterKey kCFDateFormatterDoesRelativeDateFormattingKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFDateFormatterDoesRelativeDateFormattingKey", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterDoesRelativeDateFormattingKey { get; }

		// extern const CFBooleanRef kCFBooleanTrue;
		[Field ("kCFBooleanTrue", "__Internal")]
		unsafe CFBooleanRef* kCFBooleanTrue { get; }

		// extern const CFBooleanRef kCFBooleanFalse;
		[Field ("kCFBooleanFalse", "__Internal")]
		unsafe CFBooleanRef* kCFBooleanFalse { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFNumberRef kCFNumberPositiveInfinity;
		[Field ("kCFNumberPositiveInfinity", "__Internal")]
		unsafe CFNumberRef* kCFNumberPositiveInfinity { get; }

		// extern const CFNumberRef kCFNumberNegativeInfinity;
		[Field ("kCFNumberNegativeInfinity", "__Internal")]
		unsafe CFNumberRef* kCFNumberNegativeInfinity { get; }

		// extern const CFNumberRef kCFNumberNaN;
		[Field ("kCFNumberNaN", "__Internal")]
		unsafe CFNumberRef* kCFNumberNaN { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFNumberFormatterKey kCFNumberFormatterCurrencyCode;
		[Field ("kCFNumberFormatterCurrencyCode", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterCurrencyCode { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterDecimalSeparator;
		[Field ("kCFNumberFormatterDecimalSeparator", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterDecimalSeparator { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterCurrencyDecimalSeparator;
		[Field ("kCFNumberFormatterCurrencyDecimalSeparator", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterCurrencyDecimalSeparator { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterAlwaysShowDecimalSeparator;
		[Field ("kCFNumberFormatterAlwaysShowDecimalSeparator", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterAlwaysShowDecimalSeparator { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterGroupingSeparator;
		[Field ("kCFNumberFormatterGroupingSeparator", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterGroupingSeparator { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterUseGroupingSeparator;
		[Field ("kCFNumberFormatterUseGroupingSeparator", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterUseGroupingSeparator { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterPercentSymbol;
		[Field ("kCFNumberFormatterPercentSymbol", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterPercentSymbol { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterZeroSymbol;
		[Field ("kCFNumberFormatterZeroSymbol", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterZeroSymbol { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterNaNSymbol;
		[Field ("kCFNumberFormatterNaNSymbol", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterNaNSymbol { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterInfinitySymbol;
		[Field ("kCFNumberFormatterInfinitySymbol", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterInfinitySymbol { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterMinusSign;
		[Field ("kCFNumberFormatterMinusSign", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterMinusSign { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterPlusSign;
		[Field ("kCFNumberFormatterPlusSign", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterPlusSign { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterCurrencySymbol;
		[Field ("kCFNumberFormatterCurrencySymbol", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterCurrencySymbol { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterExponentSymbol;
		[Field ("kCFNumberFormatterExponentSymbol", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterExponentSymbol { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterMinIntegerDigits;
		[Field ("kCFNumberFormatterMinIntegerDigits", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterMinIntegerDigits { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterMaxIntegerDigits;
		[Field ("kCFNumberFormatterMaxIntegerDigits", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterMaxIntegerDigits { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterMinFractionDigits;
		[Field ("kCFNumberFormatterMinFractionDigits", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterMinFractionDigits { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterMaxFractionDigits;
		[Field ("kCFNumberFormatterMaxFractionDigits", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterMaxFractionDigits { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterGroupingSize;
		[Field ("kCFNumberFormatterGroupingSize", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterGroupingSize { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterSecondaryGroupingSize;
		[Field ("kCFNumberFormatterSecondaryGroupingSize", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterSecondaryGroupingSize { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterRoundingMode;
		[Field ("kCFNumberFormatterRoundingMode", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterRoundingMode { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterRoundingIncrement;
		[Field ("kCFNumberFormatterRoundingIncrement", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterRoundingIncrement { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterFormatWidth;
		[Field ("kCFNumberFormatterFormatWidth", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterFormatWidth { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterPaddingPosition;
		[Field ("kCFNumberFormatterPaddingPosition", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterPaddingPosition { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterPaddingCharacter;
		[Field ("kCFNumberFormatterPaddingCharacter", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterPaddingCharacter { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterDefaultFormat;
		[Field ("kCFNumberFormatterDefaultFormat", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterDefaultFormat { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterMultiplier;
		[Field ("kCFNumberFormatterMultiplier", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterMultiplier { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterPositivePrefix;
		[Field ("kCFNumberFormatterPositivePrefix", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterPositivePrefix { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterPositiveSuffix;
		[Field ("kCFNumberFormatterPositiveSuffix", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterPositiveSuffix { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterNegativePrefix;
		[Field ("kCFNumberFormatterNegativePrefix", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterNegativePrefix { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterNegativeSuffix;
		[Field ("kCFNumberFormatterNegativeSuffix", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterNegativeSuffix { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterPerMillSymbol;
		[Field ("kCFNumberFormatterPerMillSymbol", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterPerMillSymbol { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterInternationalCurrencySymbol;
		[Field ("kCFNumberFormatterInternationalCurrencySymbol", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterInternationalCurrencySymbol { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterCurrencyGroupingSeparator __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFNumberFormatterCurrencyGroupingSeparator", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterCurrencyGroupingSeparator { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterIsLenient __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFNumberFormatterIsLenient", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterIsLenient { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterUseSignificantDigits __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFNumberFormatterUseSignificantDigits", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterUseSignificantDigits { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterMinSignificantDigits __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFNumberFormatterMinSignificantDigits", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterMinSignificantDigits { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterMaxSignificantDigits __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFNumberFormatterMaxSignificantDigits", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterMaxSignificantDigits { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef _Nonnull kCFPreferencesAnyApplication;
		[Field ("kCFPreferencesAnyApplication", "__Internal")]
		unsafe CFStringRef* kCFPreferencesAnyApplication { get; }

		// extern const CFStringRef _Nonnull kCFPreferencesCurrentApplication;
		[Field ("kCFPreferencesCurrentApplication", "__Internal")]
		unsafe CFStringRef* kCFPreferencesCurrentApplication { get; }

		// extern const CFStringRef _Nonnull kCFPreferencesAnyHost;
		[Field ("kCFPreferencesAnyHost", "__Internal")]
		unsafe CFStringRef* kCFPreferencesAnyHost { get; }

		// extern const CFStringRef _Nonnull kCFPreferencesCurrentHost;
		[Field ("kCFPreferencesCurrentHost", "__Internal")]
		unsafe CFStringRef* kCFPreferencesCurrentHost { get; }

		// extern const CFStringRef _Nonnull kCFPreferencesAnyUser;
		[Field ("kCFPreferencesAnyUser", "__Internal")]
		unsafe CFStringRef* kCFPreferencesAnyUser { get; }

		// extern const CFStringRef _Nonnull kCFPreferencesCurrentUser;
		[Field ("kCFPreferencesCurrentUser", "__Internal")]
		unsafe CFStringRef* kCFPreferencesCurrentUser { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef kCFURLKeysOfUnsetValuesKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLKeysOfUnsetValuesKey", "__Internal")]
		unsafe CFStringRef* kCFURLKeysOfUnsetValuesKey { get; }

		// extern const CFStringRef kCFURLNameKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLNameKey", "__Internal")]
		unsafe CFStringRef* kCFURLNameKey { get; }

		// extern const CFStringRef kCFURLLocalizedNameKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLLocalizedNameKey", "__Internal")]
		unsafe CFStringRef* kCFURLLocalizedNameKey { get; }

		// extern const CFStringRef kCFURLIsRegularFileKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLIsRegularFileKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsRegularFileKey { get; }

		// extern const CFStringRef kCFURLIsDirectoryKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLIsDirectoryKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsDirectoryKey { get; }

		// extern const CFStringRef kCFURLIsSymbolicLinkKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLIsSymbolicLinkKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsSymbolicLinkKey { get; }

		// extern const CFStringRef kCFURLIsVolumeKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLIsVolumeKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsVolumeKey { get; }

		// extern const CFStringRef kCFURLIsPackageKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLIsPackageKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsPackageKey { get; }

		// extern const CFStringRef kCFURLIsApplicationKey __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 11), iOS (9, 0)]
		[Field ("kCFURLIsApplicationKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsApplicationKey { get; }

		// extern const CFStringRef kCFURLApplicationIsScriptableKey __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 11)]
		[Field ("kCFURLApplicationIsScriptableKey", "__Internal")]
		unsafe CFStringRef* kCFURLApplicationIsScriptableKey { get; }

		// extern const CFStringRef kCFURLIsSystemImmutableKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLIsSystemImmutableKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsSystemImmutableKey { get; }

		// extern const CFStringRef kCFURLIsUserImmutableKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLIsUserImmutableKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsUserImmutableKey { get; }

		// extern const CFStringRef kCFURLIsHiddenKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLIsHiddenKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsHiddenKey { get; }

		// extern const CFStringRef kCFURLHasHiddenExtensionKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLHasHiddenExtensionKey", "__Internal")]
		unsafe CFStringRef* kCFURLHasHiddenExtensionKey { get; }

		// extern const CFStringRef kCFURLCreationDateKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLCreationDateKey", "__Internal")]
		unsafe CFStringRef* kCFURLCreationDateKey { get; }

		// extern const CFStringRef kCFURLContentAccessDateKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLContentAccessDateKey", "__Internal")]
		unsafe CFStringRef* kCFURLContentAccessDateKey { get; }

		// extern const CFStringRef kCFURLContentModificationDateKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLContentModificationDateKey", "__Internal")]
		unsafe CFStringRef* kCFURLContentModificationDateKey { get; }

		// extern const CFStringRef kCFURLAttributeModificationDateKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLAttributeModificationDateKey", "__Internal")]
		unsafe CFStringRef* kCFURLAttributeModificationDateKey { get; }

		// extern const CFStringRef kCFURLFileIdentifierKey __attribute__((availability(macos, introduced=13.3))) __attribute__((availability(ios, introduced=16.4))) __attribute__((availability(watchos, introduced=9.4))) __attribute__((availability(tvos, introduced=16.4)));
		[Watch (9, 4), TV (16, 4), Mac (13, 3), iOS (16, 4)]
		[Field ("kCFURLFileIdentifierKey", "__Internal")]
		unsafe CFStringRef* kCFURLFileIdentifierKey { get; }

		// extern const CFStringRef kCFURLFileContentIdentifierKey __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, introduced=14.0))) __attribute__((availability(watchos, introduced=7.0))) __attribute__((availability(tvos, introduced=14.0)));
		[Watch (7, 0), TV (14, 0), Mac (11, 0), iOS (14, 0)]
		[Field ("kCFURLFileContentIdentifierKey", "__Internal")]
		unsafe CFStringRef* kCFURLFileContentIdentifierKey { get; }

		// extern const CFStringRef kCFURLMayShareFileContentKey __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, introduced=14.0))) __attribute__((availability(watchos, introduced=7.0))) __attribute__((availability(tvos, introduced=14.0)));
		[Watch (7, 0), TV (14, 0), Mac (11, 0), iOS (14, 0)]
		[Field ("kCFURLMayShareFileContentKey", "__Internal")]
		unsafe CFStringRef* kCFURLMayShareFileContentKey { get; }

		// extern const CFStringRef kCFURLMayHaveExtendedAttributesKey __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, introduced=14.0))) __attribute__((availability(watchos, introduced=7.0))) __attribute__((availability(tvos, introduced=14.0)));
		[Watch (7, 0), TV (14, 0), Mac (11, 0), iOS (14, 0)]
		[Field ("kCFURLMayHaveExtendedAttributesKey", "__Internal")]
		unsafe CFStringRef* kCFURLMayHaveExtendedAttributesKey { get; }

		// extern const CFStringRef kCFURLIsPurgeableKey __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, introduced=14.0))) __attribute__((availability(watchos, introduced=7.0))) __attribute__((availability(tvos, introduced=14.0)));
		[Watch (7, 0), TV (14, 0), Mac (11, 0), iOS (14, 0)]
		[Field ("kCFURLIsPurgeableKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsPurgeableKey { get; }

		// extern const CFStringRef kCFURLIsSparseKey __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, introduced=14.0))) __attribute__((availability(watchos, introduced=7.0))) __attribute__((availability(tvos, introduced=14.0)));
		[Watch (7, 0), TV (14, 0), Mac (11, 0), iOS (14, 0)]
		[Field ("kCFURLIsSparseKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsSparseKey { get; }

		// extern const CFStringRef kCFURLLinkCountKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLLinkCountKey", "__Internal")]
		unsafe CFStringRef* kCFURLLinkCountKey { get; }

		// extern const CFStringRef kCFURLParentDirectoryURLKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLParentDirectoryURLKey", "__Internal")]
		unsafe CFStringRef* kCFURLParentDirectoryURLKey { get; }

		// extern const CFStringRef kCFURLVolumeURLKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLVolumeURLKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeURLKey { get; }

		// extern const CFStringRef kCFURLTypeIdentifierKey __attribute__((availability(macos, introduced=10.6, deprecated=100000))) __attribute__((availability(ios, introduced=4.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 6, message: "Use NSURLContentTypeKey instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use NSURLContentTypeKey instead")]
		[Introduced (PlatformName.iOS, 4, 0, message: "Use NSURLContentTypeKey instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use NSURLContentTypeKey instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use NSURLContentTypeKey instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use NSURLContentTypeKey instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use NSURLContentTypeKey instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use NSURLContentTypeKey instead")]
		[Field ("kCFURLTypeIdentifierKey", "__Internal")]
		unsafe CFStringRef* kCFURLTypeIdentifierKey { get; }

		// extern const CFStringRef kCFURLLocalizedTypeDescriptionKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLLocalizedTypeDescriptionKey", "__Internal")]
		unsafe CFStringRef* kCFURLLocalizedTypeDescriptionKey { get; }

		// extern const CFStringRef kCFURLLabelNumberKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLLabelNumberKey", "__Internal")]
		unsafe CFStringRef* kCFURLLabelNumberKey { get; }

		// extern const CFStringRef kCFURLLabelColorKey __attribute__((availability(macos, introduced=10.6, deprecated=10.12))) __attribute__((availability(ios, introduced=4.0, deprecated=10.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=3.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=10.0)));
		[Introduced (PlatformName.MacOSX, 10, 6, message: "Use NSURLLabelColorKey")]
		[Deprecated (PlatformName.MacOSX, 10, 12, message: "Use NSURLLabelColorKey")]
		[Introduced (PlatformName.iOS, 4, 0, message: "Use NSURLLabelColorKey")]
		[Deprecated (PlatformName.iOS, 10, 0, message: "Use NSURLLabelColorKey")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use NSURLLabelColorKey")]
		[Deprecated (PlatformName.WatchOS, 3, 0, message: "Use NSURLLabelColorKey")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use NSURLLabelColorKey")]
		[Deprecated (PlatformName.TvOS, 10, 0, message: "Use NSURLLabelColorKey")]
		[Field ("kCFURLLabelColorKey", "__Internal")]
		unsafe CFStringRef* kCFURLLabelColorKey { get; }

		// extern const CFStringRef kCFURLLocalizedLabelKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLLocalizedLabelKey", "__Internal")]
		unsafe CFStringRef* kCFURLLocalizedLabelKey { get; }

		// extern const CFStringRef kCFURLEffectiveIconKey __attribute__((availability(macos, introduced=10.6, deprecated=10.12))) __attribute__((availability(ios, introduced=4.0, deprecated=10.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=3.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=10.0)));
		[Introduced (PlatformName.MacOSX, 10, 6, message: "Use NSURLEffectiveIconKey")]
		[Deprecated (PlatformName.MacOSX, 10, 12, message: "Use NSURLEffectiveIconKey")]
		[Introduced (PlatformName.iOS, 4, 0, message: "Use NSURLEffectiveIconKey")]
		[Deprecated (PlatformName.iOS, 10, 0, message: "Use NSURLEffectiveIconKey")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use NSURLEffectiveIconKey")]
		[Deprecated (PlatformName.WatchOS, 3, 0, message: "Use NSURLEffectiveIconKey")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use NSURLEffectiveIconKey")]
		[Deprecated (PlatformName.TvOS, 10, 0, message: "Use NSURLEffectiveIconKey")]
		[Field ("kCFURLEffectiveIconKey", "__Internal")]
		unsafe CFStringRef* kCFURLEffectiveIconKey { get; }

		// extern const CFStringRef kCFURLCustomIconKey __attribute__((availability(macos, introduced=10.6, deprecated=10.12))) __attribute__((availability(ios, introduced=4.0, deprecated=10.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=3.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=10.0)));
		[Introduced (PlatformName.MacOSX, 10, 6, message: "Use NSURLCustomIconKey")]
		[Deprecated (PlatformName.MacOSX, 10, 12, message: "Use NSURLCustomIconKey")]
		[Introduced (PlatformName.iOS, 4, 0, message: "Use NSURLCustomIconKey")]
		[Deprecated (PlatformName.iOS, 10, 0, message: "Use NSURLCustomIconKey")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use NSURLCustomIconKey")]
		[Deprecated (PlatformName.WatchOS, 3, 0, message: "Use NSURLCustomIconKey")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use NSURLCustomIconKey")]
		[Deprecated (PlatformName.TvOS, 10, 0, message: "Use NSURLCustomIconKey")]
		[Field ("kCFURLCustomIconKey", "__Internal")]
		unsafe CFStringRef* kCFURLCustomIconKey { get; }

		// extern const CFStringRef kCFURLFileResourceIdentifierKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLFileResourceIdentifierKey", "__Internal")]
		unsafe CFStringRef* kCFURLFileResourceIdentifierKey { get; }

		// extern const CFStringRef kCFURLVolumeIdentifierKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeIdentifierKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeIdentifierKey { get; }

		// extern const CFStringRef kCFURLPreferredIOBlockSizeKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLPreferredIOBlockSizeKey", "__Internal")]
		unsafe CFStringRef* kCFURLPreferredIOBlockSizeKey { get; }

		// extern const CFStringRef kCFURLIsReadableKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLIsReadableKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsReadableKey { get; }

		// extern const CFStringRef kCFURLIsWritableKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLIsWritableKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsWritableKey { get; }

		// extern const CFStringRef kCFURLIsExecutableKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLIsExecutableKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsExecutableKey { get; }

		// extern const CFStringRef kCFURLFileSecurityKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLFileSecurityKey", "__Internal")]
		unsafe CFStringRef* kCFURLFileSecurityKey { get; }

		// extern const CFStringRef kCFURLIsExcludedFromBackupKey __attribute__((availability(macos, introduced=10.8))) __attribute__((availability(ios, introduced=5.1))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 8), iOS (5, 1)]
		[Field ("kCFURLIsExcludedFromBackupKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsExcludedFromBackupKey { get; }

		// extern const CFStringRef kCFURLTagNamesKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("kCFURLTagNamesKey", "__Internal")]
		unsafe CFStringRef* kCFURLTagNamesKey { get; }

		// extern const CFStringRef kCFURLPathKey __attribute__((availability(macos, introduced=10.8))) __attribute__((availability(ios, introduced=6.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 8), iOS (6, 0)]
		[Field ("kCFURLPathKey", "__Internal")]
		unsafe CFStringRef* kCFURLPathKey { get; }

		// extern const CFStringRef kCFURLCanonicalPathKey __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kCFURLCanonicalPathKey", "__Internal")]
		unsafe CFStringRef* kCFURLCanonicalPathKey { get; }

		// extern const CFStringRef kCFURLIsMountTriggerKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (4, 0)]
		[Field ("kCFURLIsMountTriggerKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsMountTriggerKey { get; }

		// extern const CFStringRef kCFURLGenerationIdentifierKey __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 10), iOS (8, 0)]
		[Field ("kCFURLGenerationIdentifierKey", "__Internal")]
		unsafe CFStringRef* kCFURLGenerationIdentifierKey { get; }

		// extern const CFStringRef kCFURLDocumentIdentifierKey __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 10), iOS (8, 0)]
		[Field ("kCFURLDocumentIdentifierKey", "__Internal")]
		unsafe CFStringRef* kCFURLDocumentIdentifierKey { get; }

		// extern const CFStringRef kCFURLAddedToDirectoryDateKey __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 10), iOS (8, 0)]
		[Field ("kCFURLAddedToDirectoryDateKey", "__Internal")]
		unsafe CFStringRef* kCFURLAddedToDirectoryDateKey { get; }

		// extern const CFStringRef kCFURLQuarantinePropertiesKey __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 10)]
		[Field ("kCFURLQuarantinePropertiesKey", "__Internal")]
		unsafe CFStringRef* kCFURLQuarantinePropertiesKey { get; }

		// extern const CFStringRef kCFURLFileResourceTypeKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLFileResourceTypeKey", "__Internal")]
		unsafe CFStringRef* kCFURLFileResourceTypeKey { get; }

		// extern const CFStringRef kCFURLFileResourceTypeNamedPipe __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLFileResourceTypeNamedPipe", "__Internal")]
		unsafe CFStringRef* kCFURLFileResourceTypeNamedPipe { get; }

		// extern const CFStringRef kCFURLFileResourceTypeCharacterSpecial __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLFileResourceTypeCharacterSpecial", "__Internal")]
		unsafe CFStringRef* kCFURLFileResourceTypeCharacterSpecial { get; }

		// extern const CFStringRef kCFURLFileResourceTypeDirectory __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLFileResourceTypeDirectory", "__Internal")]
		unsafe CFStringRef* kCFURLFileResourceTypeDirectory { get; }

		// extern const CFStringRef kCFURLFileResourceTypeBlockSpecial __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLFileResourceTypeBlockSpecial", "__Internal")]
		unsafe CFStringRef* kCFURLFileResourceTypeBlockSpecial { get; }

		// extern const CFStringRef kCFURLFileResourceTypeRegular __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLFileResourceTypeRegular", "__Internal")]
		unsafe CFStringRef* kCFURLFileResourceTypeRegular { get; }

		// extern const CFStringRef kCFURLFileResourceTypeSymbolicLink __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLFileResourceTypeSymbolicLink", "__Internal")]
		unsafe CFStringRef* kCFURLFileResourceTypeSymbolicLink { get; }

		// extern const CFStringRef kCFURLFileResourceTypeSocket __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLFileResourceTypeSocket", "__Internal")]
		unsafe CFStringRef* kCFURLFileResourceTypeSocket { get; }

		// extern const CFStringRef kCFURLFileResourceTypeUnknown __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLFileResourceTypeUnknown", "__Internal")]
		unsafe CFStringRef* kCFURLFileResourceTypeUnknown { get; }

		// extern const CFStringRef kCFURLFileSizeKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLFileSizeKey", "__Internal")]
		unsafe CFStringRef* kCFURLFileSizeKey { get; }

		// extern const CFStringRef kCFURLFileAllocatedSizeKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLFileAllocatedSizeKey", "__Internal")]
		unsafe CFStringRef* kCFURLFileAllocatedSizeKey { get; }

		// extern const CFStringRef kCFURLTotalFileSizeKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLTotalFileSizeKey", "__Internal")]
		unsafe CFStringRef* kCFURLTotalFileSizeKey { get; }

		// extern const CFStringRef kCFURLTotalFileAllocatedSizeKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLTotalFileAllocatedSizeKey", "__Internal")]
		unsafe CFStringRef* kCFURLTotalFileAllocatedSizeKey { get; }

		// extern const CFStringRef kCFURLIsAliasFileKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLIsAliasFileKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsAliasFileKey { get; }

		// extern const CFStringRef kCFURLFileProtectionKey __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(macos, unavailable)));
		[Watch (2, 0), TV (9, 0), NoMac, iOS (9, 0)]
		[Field ("kCFURLFileProtectionKey", "__Internal")]
		unsafe CFStringRef* kCFURLFileProtectionKey { get; }

		// extern const CFStringRef kCFURLFileProtectionNone __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(macos, unavailable)));
		[Watch (2, 0), TV (9, 0), NoMac, iOS (9, 0)]
		[Field ("kCFURLFileProtectionNone", "__Internal")]
		unsafe CFStringRef* kCFURLFileProtectionNone { get; }

		// extern const CFStringRef kCFURLFileProtectionComplete __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(macos, unavailable)));
		[Watch (2, 0), TV (9, 0), NoMac, iOS (9, 0)]
		[Field ("kCFURLFileProtectionComplete", "__Internal")]
		unsafe CFStringRef* kCFURLFileProtectionComplete { get; }

		// extern const CFStringRef kCFURLFileProtectionCompleteUnlessOpen __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(macos, unavailable)));
		[Watch (2, 0), TV (9, 0), NoMac, iOS (9, 0)]
		[Field ("kCFURLFileProtectionCompleteUnlessOpen", "__Internal")]
		unsafe CFStringRef* kCFURLFileProtectionCompleteUnlessOpen { get; }

		// extern const CFStringRef kCFURLFileProtectionCompleteUntilFirstUserAuthentication __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(macos, unavailable)));
		[Watch (2, 0), TV (9, 0), NoMac, iOS (9, 0)]
		[Field ("kCFURLFileProtectionCompleteUntilFirstUserAuthentication", "__Internal")]
		unsafe CFStringRef* kCFURLFileProtectionCompleteUntilFirstUserAuthentication { get; }

		// extern const CFStringRef kCFURLVolumeLocalizedFormatDescriptionKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLVolumeLocalizedFormatDescriptionKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeLocalizedFormatDescriptionKey { get; }

		// extern const CFStringRef kCFURLVolumeTotalCapacityKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLVolumeTotalCapacityKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeTotalCapacityKey { get; }

		// extern const CFStringRef kCFURLVolumeAvailableCapacityKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLVolumeAvailableCapacityKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeAvailableCapacityKey { get; }

		// extern const CFStringRef kCFURLVolumeAvailableCapacityForImportantUsageKey __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, Mac (10, 13), iOS (11, 0)]
		[Field ("kCFURLVolumeAvailableCapacityForImportantUsageKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeAvailableCapacityForImportantUsageKey { get; }

		// extern const CFStringRef kCFURLVolumeAvailableCapacityForOpportunisticUsageKey __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, Mac (10, 13), iOS (11, 0)]
		[Field ("kCFURLVolumeAvailableCapacityForOpportunisticUsageKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeAvailableCapacityForOpportunisticUsageKey { get; }

		// extern const CFStringRef kCFURLVolumeResourceCountKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLVolumeResourceCountKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeResourceCountKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsPersistentIDsKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLVolumeSupportsPersistentIDsKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsPersistentIDsKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsSymbolicLinksKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLVolumeSupportsSymbolicLinksKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsSymbolicLinksKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsHardLinksKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLVolumeSupportsHardLinksKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsHardLinksKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsJournalingKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLVolumeSupportsJournalingKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsJournalingKey { get; }

		// extern const CFStringRef kCFURLVolumeIsJournalingKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLVolumeIsJournalingKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeIsJournalingKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsSparseFilesKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLVolumeSupportsSparseFilesKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsSparseFilesKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsZeroRunsKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLVolumeSupportsZeroRunsKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsZeroRunsKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsCaseSensitiveNamesKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLVolumeSupportsCaseSensitiveNamesKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsCaseSensitiveNamesKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsCasePreservedNamesKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLVolumeSupportsCasePreservedNamesKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsCasePreservedNamesKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsRootDirectoryDatesKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeSupportsRootDirectoryDatesKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsRootDirectoryDatesKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsVolumeSizesKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeSupportsVolumeSizesKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsVolumeSizesKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsRenamingKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeSupportsRenamingKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsRenamingKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsAdvisoryFileLockingKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeSupportsAdvisoryFileLockingKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsAdvisoryFileLockingKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsExtendedSecurityKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeSupportsExtendedSecurityKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsExtendedSecurityKey { get; }

		// extern const CFStringRef kCFURLVolumeIsBrowsableKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeIsBrowsableKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeIsBrowsableKey { get; }

		// extern const CFStringRef kCFURLVolumeMaximumFileSizeKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeMaximumFileSizeKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeMaximumFileSizeKey { get; }

		// extern const CFStringRef kCFURLVolumeIsEjectableKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeIsEjectableKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeIsEjectableKey { get; }

		// extern const CFStringRef kCFURLVolumeIsRemovableKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeIsRemovableKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeIsRemovableKey { get; }

		// extern const CFStringRef kCFURLVolumeIsInternalKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeIsInternalKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeIsInternalKey { get; }

		// extern const CFStringRef kCFURLVolumeIsAutomountedKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeIsAutomountedKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeIsAutomountedKey { get; }

		// extern const CFStringRef kCFURLVolumeIsLocalKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeIsLocalKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeIsLocalKey { get; }

		// extern const CFStringRef kCFURLVolumeIsReadOnlyKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeIsReadOnlyKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeIsReadOnlyKey { get; }

		// extern const CFStringRef kCFURLVolumeCreationDateKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeCreationDateKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeCreationDateKey { get; }

		// extern const CFStringRef kCFURLVolumeURLForRemountingKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeURLForRemountingKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeURLForRemountingKey { get; }

		// extern const CFStringRef kCFURLVolumeUUIDStringKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeUUIDStringKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeUUIDStringKey { get; }

		// extern const CFStringRef kCFURLVolumeNameKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeNameKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeNameKey { get; }

		// extern const CFStringRef kCFURLVolumeLocalizedNameKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeLocalizedNameKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeLocalizedNameKey { get; }

		// extern const CFStringRef kCFURLVolumeIsEncryptedKey __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kCFURLVolumeIsEncryptedKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeIsEncryptedKey { get; }

		// extern const CFStringRef kCFURLVolumeIsRootFileSystemKey __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kCFURLVolumeIsRootFileSystemKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeIsRootFileSystemKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsCompressionKey __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kCFURLVolumeSupportsCompressionKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsCompressionKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsFileCloningKey __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kCFURLVolumeSupportsFileCloningKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsFileCloningKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsSwapRenamingKey __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kCFURLVolumeSupportsSwapRenamingKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsSwapRenamingKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsExclusiveRenamingKey __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kCFURLVolumeSupportsExclusiveRenamingKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsExclusiveRenamingKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsImmutableFilesKey __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0))) __attribute__((availability(tvos, introduced=11.0)));
		[Watch (4, 0), TV (11, 0), Mac (10, 13), iOS (11, 0)]
		[Field ("kCFURLVolumeSupportsImmutableFilesKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsImmutableFilesKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsAccessPermissionsKey __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0))) __attribute__((availability(tvos, introduced=11.0)));
		[Watch (4, 0), TV (11, 0), Mac (10, 13), iOS (11, 0)]
		[Field ("kCFURLVolumeSupportsAccessPermissionsKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsAccessPermissionsKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsFileProtectionKey __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, introduced=14.0))) __attribute__((availability(watchos, introduced=7.0))) __attribute__((availability(tvos, introduced=14.0)));
		[Watch (7, 0), TV (14, 0), Mac (11, 0), iOS (14, 0)]
		[Field ("kCFURLVolumeSupportsFileProtectionKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsFileProtectionKey { get; }

		// extern const CFStringRef kCFURLVolumeTypeNameKey __attribute__((availability(macos, introduced=13.3))) __attribute__((availability(ios, introduced=16.4))) __attribute__((availability(watchos, introduced=9.4))) __attribute__((availability(tvos, introduced=16.4)));
		[Watch (9, 4), TV (16, 4), Mac (13, 3), iOS (16, 4)]
		[Field ("kCFURLVolumeTypeNameKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeTypeNameKey { get; }

		// extern const CFStringRef kCFURLVolumeSubtypeKey __attribute__((availability(macos, introduced=13.3))) __attribute__((availability(ios, introduced=16.4))) __attribute__((availability(watchos, introduced=9.4))) __attribute__((availability(tvos, introduced=16.4)));
		[Watch (9, 4), TV (16, 4), Mac (13, 3), iOS (16, 4)]
		[Field ("kCFURLVolumeSubtypeKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSubtypeKey { get; }

		// extern const CFStringRef kCFURLVolumeMountFromLocationKey __attribute__((availability(macos, introduced=13.3))) __attribute__((availability(ios, introduced=16.4))) __attribute__((availability(watchos, introduced=9.4))) __attribute__((availability(tvos, introduced=16.4)));
		[Watch (9, 4), TV (16, 4), Mac (13, 3), iOS (16, 4)]
		[Field ("kCFURLVolumeMountFromLocationKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeMountFromLocationKey { get; }

		// extern const CFStringRef kCFURLIsUbiquitousItemKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLIsUbiquitousItemKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsUbiquitousItemKey { get; }

		// extern const CFStringRef kCFURLUbiquitousItemHasUnresolvedConflictsKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLUbiquitousItemHasUnresolvedConflictsKey", "__Internal")]
		unsafe CFStringRef* kCFURLUbiquitousItemHasUnresolvedConflictsKey { get; }

		// extern const CFStringRef kCFURLUbiquitousItemIsDownloadedKey __attribute__((availability(macos, introduced=10.7, deprecated=10.9))) __attribute__((availability(ios, introduced=5.0, deprecated=7.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 7, message: "Use kCFURLUbiquitousItemDownloadingStatusKey instead")]
		[Deprecated (PlatformName.MacOSX, 10, 9, message: "Use kCFURLUbiquitousItemDownloadingStatusKey instead")]
		[Introduced (PlatformName.iOS, 5, 0, message: "Use kCFURLUbiquitousItemDownloadingStatusKey instead")]
		[Deprecated (PlatformName.iOS, 7, 0, message: "Use kCFURLUbiquitousItemDownloadingStatusKey instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use kCFURLUbiquitousItemDownloadingStatusKey instead")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use kCFURLUbiquitousItemDownloadingStatusKey instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use kCFURLUbiquitousItemDownloadingStatusKey instead")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use kCFURLUbiquitousItemDownloadingStatusKey instead")]
		[Field ("kCFURLUbiquitousItemIsDownloadedKey", "__Internal")]
		unsafe CFStringRef* kCFURLUbiquitousItemIsDownloadedKey { get; }

		// extern const CFStringRef kCFURLUbiquitousItemIsDownloadingKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLUbiquitousItemIsDownloadingKey", "__Internal")]
		unsafe CFStringRef* kCFURLUbiquitousItemIsDownloadingKey { get; }

		// extern const CFStringRef kCFURLUbiquitousItemIsUploadedKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLUbiquitousItemIsUploadedKey", "__Internal")]
		unsafe CFStringRef* kCFURLUbiquitousItemIsUploadedKey { get; }

		// extern const CFStringRef kCFURLUbiquitousItemIsUploadingKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLUbiquitousItemIsUploadingKey", "__Internal")]
		unsafe CFStringRef* kCFURLUbiquitousItemIsUploadingKey { get; }

		// extern const CFStringRef kCFURLUbiquitousItemPercentDownloadedKey __attribute__((availability(macos, introduced=10.7, deprecated=10.8))) __attribute__((availability(ios, introduced=5.0, deprecated=6.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 7, message: "Use NSMetadataQuery and NSMetadataUbiquitousItemPercentDownloadedKey on NSMetadataItem instead")]
		[Deprecated (PlatformName.MacOSX, 10, 8, message: "Use NSMetadataQuery and NSMetadataUbiquitousItemPercentDownloadedKey on NSMetadataItem instead")]
		[Introduced (PlatformName.iOS, 5, 0, message: "Use NSMetadataQuery and NSMetadataUbiquitousItemPercentDownloadedKey on NSMetadataItem instead")]
		[Deprecated (PlatformName.iOS, 6, 0, message: "Use NSMetadataQuery and NSMetadataUbiquitousItemPercentDownloadedKey on NSMetadataItem instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use NSMetadataQuery and NSMetadataUbiquitousItemPercentDownloadedKey on NSMetadataItem instead")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use NSMetadataQuery and NSMetadataUbiquitousItemPercentDownloadedKey on NSMetadataItem instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use NSMetadataQuery and NSMetadataUbiquitousItemPercentDownloadedKey on NSMetadataItem instead")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use NSMetadataQuery and NSMetadataUbiquitousItemPercentDownloadedKey on NSMetadataItem instead")]
		[Field ("kCFURLUbiquitousItemPercentDownloadedKey", "__Internal")]
		unsafe CFStringRef* kCFURLUbiquitousItemPercentDownloadedKey { get; }

		// extern const CFStringRef kCFURLUbiquitousItemPercentUploadedKey __attribute__((availability(macos, introduced=10.7, deprecated=10.8))) __attribute__((availability(ios, introduced=5.0, deprecated=6.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 7, message: "Use NSMetadataQuery and NSMetadataUbiquitousItemPercentUploadedKey on NSMetadataItem instead")]
		[Deprecated (PlatformName.MacOSX, 10, 8, message: "Use NSMetadataQuery and NSMetadataUbiquitousItemPercentUploadedKey on NSMetadataItem instead")]
		[Introduced (PlatformName.iOS, 5, 0, message: "Use NSMetadataQuery and NSMetadataUbiquitousItemPercentUploadedKey on NSMetadataItem instead")]
		[Deprecated (PlatformName.iOS, 6, 0, message: "Use NSMetadataQuery and NSMetadataUbiquitousItemPercentUploadedKey on NSMetadataItem instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use NSMetadataQuery and NSMetadataUbiquitousItemPercentUploadedKey on NSMetadataItem instead")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use NSMetadataQuery and NSMetadataUbiquitousItemPercentUploadedKey on NSMetadataItem instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use NSMetadataQuery and NSMetadataUbiquitousItemPercentUploadedKey on NSMetadataItem instead")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use NSMetadataQuery and NSMetadataUbiquitousItemPercentUploadedKey on NSMetadataItem instead")]
		[Field ("kCFURLUbiquitousItemPercentUploadedKey", "__Internal")]
		unsafe CFStringRef* kCFURLUbiquitousItemPercentUploadedKey { get; }

		// extern const CFStringRef kCFURLUbiquitousItemDownloadingStatusKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("kCFURLUbiquitousItemDownloadingStatusKey", "__Internal")]
		unsafe CFStringRef* kCFURLUbiquitousItemDownloadingStatusKey { get; }

		// extern const CFStringRef kCFURLUbiquitousItemDownloadingErrorKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("kCFURLUbiquitousItemDownloadingErrorKey", "__Internal")]
		unsafe CFStringRef* kCFURLUbiquitousItemDownloadingErrorKey { get; }

		// extern const CFStringRef kCFURLUbiquitousItemUploadingErrorKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("kCFURLUbiquitousItemUploadingErrorKey", "__Internal")]
		unsafe CFStringRef* kCFURLUbiquitousItemUploadingErrorKey { get; }

		// extern const CFStringRef kCFURLUbiquitousItemIsExcludedFromSyncKey __attribute__((availability(macos, introduced=11.3))) __attribute__((availability(ios, introduced=14.5))) __attribute__((availability(watchos, introduced=7.4))) __attribute__((availability(tvos, introduced=14.5)));
		[Watch (7, 4), TV (14, 5), Mac (11, 3), iOS (14, 5)]
		[Field ("kCFURLUbiquitousItemIsExcludedFromSyncKey", "__Internal")]
		unsafe CFStringRef* kCFURLUbiquitousItemIsExcludedFromSyncKey { get; }

		// extern const CFStringRef kCFURLUbiquitousItemDownloadingStatusNotDownloaded __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("kCFURLUbiquitousItemDownloadingStatusNotDownloaded", "__Internal")]
		unsafe CFStringRef* kCFURLUbiquitousItemDownloadingStatusNotDownloaded { get; }

		// extern const CFStringRef kCFURLUbiquitousItemDownloadingStatusDownloaded __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("kCFURLUbiquitousItemDownloadingStatusDownloaded", "__Internal")]
		unsafe CFStringRef* kCFURLUbiquitousItemDownloadingStatusDownloaded { get; }

		// extern const CFStringRef kCFURLUbiquitousItemDownloadingStatusCurrent __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("kCFURLUbiquitousItemDownloadingStatusCurrent", "__Internal")]
		unsafe CFStringRef* kCFURLUbiquitousItemDownloadingStatusCurrent { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFRunLoopMode kCFRunLoopDefaultMode;
		[Field ("kCFRunLoopDefaultMode", "__Internal")]
		unsafe CFRunLoopMode* kCFRunLoopDefaultMode { get; }

		// extern const CFRunLoopMode kCFRunLoopCommonModes;
		[Field ("kCFRunLoopCommonModes", "__Internal")]
		unsafe CFRunLoopMode* kCFRunLoopCommonModes { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef kCFSocketCommandKey;
		[Field ("kCFSocketCommandKey", "__Internal")]
		unsafe CFStringRef* kCFSocketCommandKey { get; }

		// extern const CFStringRef kCFSocketNameKey;
		[Field ("kCFSocketNameKey", "__Internal")]
		unsafe CFStringRef* kCFSocketNameKey { get; }

		// extern const CFStringRef kCFSocketValueKey;
		[Field ("kCFSocketValueKey", "__Internal")]
		unsafe CFStringRef* kCFSocketValueKey { get; }

		// extern const CFStringRef kCFSocketResultKey;
		[Field ("kCFSocketResultKey", "__Internal")]
		unsafe CFStringRef* kCFSocketResultKey { get; }

		// extern const CFStringRef kCFSocketErrorKey;
		[Field ("kCFSocketErrorKey", "__Internal")]
		unsafe CFStringRef* kCFSocketErrorKey { get; }

		// extern const CFStringRef kCFSocketRegisterCommand;
		[Field ("kCFSocketRegisterCommand", "__Internal")]
		unsafe CFStringRef* kCFSocketRegisterCommand { get; }

		// extern const CFStringRef kCFSocketRetrieveCommand;
		[Field ("kCFSocketRetrieveCommand", "__Internal")]
		unsafe CFStringRef* kCFSocketRetrieveCommand { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern CFStreamPropertyKey  _Null_unspecified const kCFStreamPropertyDataWritten;
		[Field ("kCFStreamPropertyDataWritten", "__Internal")]
		unsafe CFStreamPropertyKey* kCFStreamPropertyDataWritten { get; }

		// extern CFStreamPropertyKey  _Null_unspecified const kCFStreamPropertyAppendToFile;
		[Field ("kCFStreamPropertyAppendToFile", "__Internal")]
		unsafe CFStreamPropertyKey* kCFStreamPropertyAppendToFile { get; }

		// extern CFStreamPropertyKey  _Null_unspecified const kCFStreamPropertyFileCurrentOffset;
		[Field ("kCFStreamPropertyFileCurrentOffset", "__Internal")]
		unsafe CFStreamPropertyKey* kCFStreamPropertyFileCurrentOffset { get; }

		// extern CFStreamPropertyKey  _Null_unspecified const kCFStreamPropertySocketNativeHandle;
		[Field ("kCFStreamPropertySocketNativeHandle", "__Internal")]
		unsafe CFStreamPropertyKey* kCFStreamPropertySocketNativeHandle { get; }

		// extern CFStreamPropertyKey  _Null_unspecified const kCFStreamPropertySocketRemoteHostName;
		[Field ("kCFStreamPropertySocketRemoteHostName", "__Internal")]
		unsafe CFStreamPropertyKey* kCFStreamPropertySocketRemoteHostName { get; }

		// extern CFStreamPropertyKey  _Null_unspecified const kCFStreamPropertySocketRemotePortNumber;
		[Field ("kCFStreamPropertySocketRemotePortNumber", "__Internal")]
		unsafe CFStreamPropertyKey* kCFStreamPropertySocketRemotePortNumber { get; }

		// extern const int kCFStreamErrorDomainSOCKS __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamErrorDomainSOCKS", "__Internal")]
		int kCFStreamErrorDomainSOCKS { get; }

		// extern CFStringRef  _Nonnull const kCFStreamPropertySOCKSProxy __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamPropertySOCKSProxy", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertySOCKSProxy { get; }

		// extern CFStringRef  _Nonnull const kCFStreamPropertySOCKSProxyHost __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamPropertySOCKSProxyHost", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertySOCKSProxyHost { get; }

		// extern CFStringRef  _Nonnull const kCFStreamPropertySOCKSProxyPort __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamPropertySOCKSProxyPort", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertySOCKSProxyPort { get; }

		// extern CFStringRef  _Nonnull const kCFStreamPropertySOCKSVersion __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamPropertySOCKSVersion", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertySOCKSVersion { get; }

		// extern CFStringRef  _Nonnull const kCFStreamSocketSOCKSVersion4 __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamSocketSOCKSVersion4", "__Internal")]
		unsafe CFStringRef* kCFStreamSocketSOCKSVersion4 { get; }

		// extern CFStringRef  _Nonnull const kCFStreamSocketSOCKSVersion5 __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamSocketSOCKSVersion5", "__Internal")]
		unsafe CFStringRef* kCFStreamSocketSOCKSVersion5 { get; }

		// extern CFStringRef  _Nonnull const kCFStreamPropertySOCKSUser __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamPropertySOCKSUser", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertySOCKSUser { get; }

		// extern CFStringRef  _Nonnull const kCFStreamPropertySOCKSPassword __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamPropertySOCKSPassword", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertySOCKSPassword { get; }

		// extern const int kCFStreamErrorDomainSSL __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamErrorDomainSSL", "__Internal")]
		int kCFStreamErrorDomainSSL { get; }

		// extern CFStringRef  _Nonnull const kCFStreamPropertySocketSecurityLevel __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamPropertySocketSecurityLevel", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertySocketSecurityLevel { get; }

		// extern CFStringRef  _Nonnull const kCFStreamSocketSecurityLevelNone __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamSocketSecurityLevelNone", "__Internal")]
		unsafe CFStringRef* kCFStreamSocketSecurityLevelNone { get; }

		// extern CFStringRef  _Nonnull const kCFStreamSocketSecurityLevelSSLv2 __attribute__((availability(ios, introduced=2.0, deprecated=10.0)));
		[Introduced (PlatformName.iOS, 2, 0)]
		[Deprecated (PlatformName.iOS, 10, 0)]
		[Field ("kCFStreamSocketSecurityLevelSSLv2", "__Internal")]
		unsafe CFStringRef* kCFStreamSocketSecurityLevelSSLv2 { get; }

		// extern CFStringRef  _Nonnull const kCFStreamSocketSecurityLevelSSLv3 __attribute__((availability(ios, introduced=2.0, deprecated=10.0)));
		[Introduced (PlatformName.iOS, 2, 0)]
		[Deprecated (PlatformName.iOS, 10, 0)]
		[Field ("kCFStreamSocketSecurityLevelSSLv3", "__Internal")]
		unsafe CFStringRef* kCFStreamSocketSecurityLevelSSLv3 { get; }

		// extern CFStringRef  _Nonnull const kCFStreamSocketSecurityLevelTLSv1 __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamSocketSecurityLevelTLSv1", "__Internal")]
		unsafe CFStringRef* kCFStreamSocketSecurityLevelTLSv1 { get; }

		// extern CFStringRef  _Nonnull const kCFStreamSocketSecurityLevelNegotiatedSSL __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamSocketSecurityLevelNegotiatedSSL", "__Internal")]
		unsafe CFStringRef* kCFStreamSocketSecurityLevelNegotiatedSSL { get; }

		// extern CFStringRef  _Nonnull const kCFStreamPropertyShouldCloseNativeSocket __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamPropertyShouldCloseNativeSocket", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertyShouldCloseNativeSocket { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFSetCallBacks kCFTypeSetCallBacks;
		[Field ("kCFTypeSetCallBacks", "__Internal")]
		CFSetCallBacks kCFTypeSetCallBacks { get; }

		// extern const CFSetCallBacks kCFCopyStringSetCallBacks;
		[Field ("kCFCopyStringSetCallBacks", "__Internal")]
		CFSetCallBacks kCFCopyStringSetCallBacks { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef kCFURLFileExists __attribute__((availability(macos, introduced=10.0, deprecated=10.9))) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "Use CFURLResourceIsReachable instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 9, message: "Use CFURLResourceIsReachable instead.")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use CFURLResourceIsReachable instead.")]
		[Deprecated (PlatformName.iOS, 7, 0, message: "Use CFURLResourceIsReachable instead.")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use CFURLResourceIsReachable instead.")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use CFURLResourceIsReachable instead.")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use CFURLResourceIsReachable instead.")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use CFURLResourceIsReachable instead.")]
		[Field ("kCFURLFileExists", "__Internal")]
		unsafe CFStringRef* kCFURLFileExists { get; }

		// extern const CFStringRef kCFURLFileDirectoryContents __attribute__((availability(macos, introduced=10.0, deprecated=10.9))) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "Use the CFURLEnumerator API instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 9, message: "Use the CFURLEnumerator API instead.")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use the CFURLEnumerator API instead.")]
		[Deprecated (PlatformName.iOS, 7, 0, message: "Use the CFURLEnumerator API instead.")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use the CFURLEnumerator API instead.")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use the CFURLEnumerator API instead.")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use the CFURLEnumerator API instead.")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use the CFURLEnumerator API instead.")]
		[Field ("kCFURLFileDirectoryContents", "__Internal")]
		unsafe CFStringRef* kCFURLFileDirectoryContents { get; }

		// extern const CFStringRef kCFURLFileLength __attribute__((availability(macos, introduced=10.0, deprecated=10.9))) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSizeKey instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 9, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSizeKey instead.")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSizeKey instead.")]
		[Deprecated (PlatformName.iOS, 7, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSizeKey instead.")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSizeKey instead.")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSizeKey instead.")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSizeKey instead.")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSizeKey instead.")]
		[Field ("kCFURLFileLength", "__Internal")]
		unsafe CFStringRef* kCFURLFileLength { get; }

		// extern const CFStringRef kCFURLFileLastModificationTime __attribute__((availability(macos, introduced=10.0, deprecated=10.9))) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLContentModificationDateKey instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 9, message: "Use CFURLCopyResourcePropertyForKey with kCFURLContentModificationDateKey instead.")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLContentModificationDateKey instead.")]
		[Deprecated (PlatformName.iOS, 7, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLContentModificationDateKey instead.")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLContentModificationDateKey instead.")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLContentModificationDateKey instead.")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLContentModificationDateKey instead.")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLContentModificationDateKey instead.")]
		[Field ("kCFURLFileLastModificationTime", "__Internal")]
		unsafe CFStringRef* kCFURLFileLastModificationTime { get; }

		// extern const CFStringRef kCFURLFilePOSIXMode __attribute__((availability(macos, introduced=10.0, deprecated=10.9))) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSecurityKey and then the CFFileSecurity API instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 9, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSecurityKey and then the CFFileSecurity API instead.")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSecurityKey and then the CFFileSecurity API instead.")]
		[Deprecated (PlatformName.iOS, 7, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSecurityKey and then the CFFileSecurity API instead.")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSecurityKey and then the CFFileSecurity API instead.")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSecurityKey and then the CFFileSecurity API instead.")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSecurityKey and then the CFFileSecurity API instead.")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSecurityKey and then the CFFileSecurity API instead.")]
		[Field ("kCFURLFilePOSIXMode", "__Internal")]
		unsafe CFStringRef* kCFURLFilePOSIXMode { get; }

		// extern const CFStringRef kCFURLFileOwnerID __attribute__((availability(macos, introduced=10.0, deprecated=10.9))) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSecurityKey and then the CFFileSecurity API instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 9, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSecurityKey and then the CFFileSecurity API instead.")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSecurityKey and then the CFFileSecurity API instead.")]
		[Deprecated (PlatformName.iOS, 7, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSecurityKey and then the CFFileSecurity API instead.")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSecurityKey and then the CFFileSecurity API instead.")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSecurityKey and then the CFFileSecurity API instead.")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSecurityKey and then the CFFileSecurity API instead.")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSecurityKey and then the CFFileSecurity API instead.")]
		[Field ("kCFURLFileOwnerID", "__Internal")]
		unsafe CFStringRef* kCFURLFileOwnerID { get; }

		// extern const CFStringRef kCFURLHTTPStatusCode __attribute__((availability(macos, introduced=10.0, deprecated=10.9))) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "Use NSHTTPURLResponse methods instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 9, message: "Use NSHTTPURLResponse methods instead.")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSHTTPURLResponse methods instead.")]
		[Deprecated (PlatformName.iOS, 7, 0, message: "Use NSHTTPURLResponse methods instead.")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use NSHTTPURLResponse methods instead.")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use NSHTTPURLResponse methods instead.")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use NSHTTPURLResponse methods instead.")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use NSHTTPURLResponse methods instead.")]
		[Field ("kCFURLHTTPStatusCode", "__Internal")]
		unsafe CFStringRef* kCFURLHTTPStatusCode { get; }

		// extern const CFStringRef kCFURLHTTPStatusLine __attribute__((availability(macos, introduced=10.0, deprecated=10.9))) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "Use NSHTTPURLResponse methods instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 9, message: "Use NSHTTPURLResponse methods instead.")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSHTTPURLResponse methods instead.")]
		[Deprecated (PlatformName.iOS, 7, 0, message: "Use NSHTTPURLResponse methods instead.")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use NSHTTPURLResponse methods instead.")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use NSHTTPURLResponse methods instead.")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use NSHTTPURLResponse methods instead.")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use NSHTTPURLResponse methods instead.")]
		[Field ("kCFURLHTTPStatusLine", "__Internal")]
		unsafe CFStringRef* kCFURLHTTPStatusLine { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef kCFBundleInfoDictionaryVersionKey;
		[Field ("kCFBundleInfoDictionaryVersionKey", "__Internal")]
		unsafe CFStringRef* kCFBundleInfoDictionaryVersionKey { get; }

		// extern const CFStringRef kCFBundleExecutableKey;
		[Field ("kCFBundleExecutableKey", "__Internal")]
		unsafe CFStringRef* kCFBundleExecutableKey { get; }

		// extern const CFStringRef kCFBundleIdentifierKey;
		[Field ("kCFBundleIdentifierKey", "__Internal")]
		unsafe CFStringRef* kCFBundleIdentifierKey { get; }

		// extern const CFStringRef kCFBundleVersionKey;
		[Field ("kCFBundleVersionKey", "__Internal")]
		unsafe CFStringRef* kCFBundleVersionKey { get; }

		// extern const CFStringRef kCFBundleDevelopmentRegionKey;
		[Field ("kCFBundleDevelopmentRegionKey", "__Internal")]
		unsafe CFStringRef* kCFBundleDevelopmentRegionKey { get; }

		// extern const CFStringRef kCFBundleNameKey;
		[Field ("kCFBundleNameKey", "__Internal")]
		unsafe CFStringRef* kCFBundleNameKey { get; }

		// extern const CFStringRef kCFBundleLocalizationsKey;
		[Field ("kCFBundleLocalizationsKey", "__Internal")]
		unsafe CFStringRef* kCFBundleLocalizationsKey { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef kCFPlugInDynamicRegistrationKey;
		[Field ("kCFPlugInDynamicRegistrationKey", "__Internal")]
		unsafe CFStringRef* kCFPlugInDynamicRegistrationKey { get; }

		// extern const CFStringRef kCFPlugInDynamicRegisterFunctionKey;
		[Field ("kCFPlugInDynamicRegisterFunctionKey", "__Internal")]
		unsafe CFStringRef* kCFPlugInDynamicRegisterFunctionKey { get; }

		// extern const CFStringRef kCFPlugInUnloadFunctionKey;
		[Field ("kCFPlugInUnloadFunctionKey", "__Internal")]
		unsafe CFStringRef* kCFPlugInUnloadFunctionKey { get; }

		// extern const CFStringRef kCFPlugInFactoriesKey;
		[Field ("kCFPlugInFactoriesKey", "__Internal")]
		unsafe CFStringRef* kCFPlugInFactoriesKey { get; }

		// extern const CFStringRef kCFPlugInTypesKey;
		[Field ("kCFPlugInTypesKey", "__Internal")]
		unsafe CFStringRef* kCFPlugInTypesKey { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef kCFUserNotificationIconURLKey __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 0)]
		[Field ("kCFUserNotificationIconURLKey", "__Internal")]
		unsafe CFStringRef* kCFUserNotificationIconURLKey { get; }

		// extern const CFStringRef kCFUserNotificationSoundURLKey __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 0)]
		[Field ("kCFUserNotificationSoundURLKey", "__Internal")]
		unsafe CFStringRef* kCFUserNotificationSoundURLKey { get; }

		// extern const CFStringRef kCFUserNotificationLocalizationURLKey __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 0)]
		[Field ("kCFUserNotificationLocalizationURLKey", "__Internal")]
		unsafe CFStringRef* kCFUserNotificationLocalizationURLKey { get; }

		// extern const CFStringRef kCFUserNotificationAlertHeaderKey __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 0)]
		[Field ("kCFUserNotificationAlertHeaderKey", "__Internal")]
		unsafe CFStringRef* kCFUserNotificationAlertHeaderKey { get; }

		// extern const CFStringRef kCFUserNotificationAlertMessageKey __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 0)]
		[Field ("kCFUserNotificationAlertMessageKey", "__Internal")]
		unsafe CFStringRef* kCFUserNotificationAlertMessageKey { get; }

		// extern const CFStringRef kCFUserNotificationDefaultButtonTitleKey __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 0)]
		[Field ("kCFUserNotificationDefaultButtonTitleKey", "__Internal")]
		unsafe CFStringRef* kCFUserNotificationDefaultButtonTitleKey { get; }

		// extern const CFStringRef kCFUserNotificationAlternateButtonTitleKey __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 0)]
		[Field ("kCFUserNotificationAlternateButtonTitleKey", "__Internal")]
		unsafe CFStringRef* kCFUserNotificationAlternateButtonTitleKey { get; }

		// extern const CFStringRef kCFUserNotificationOtherButtonTitleKey __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 0)]
		[Field ("kCFUserNotificationOtherButtonTitleKey", "__Internal")]
		unsafe CFStringRef* kCFUserNotificationOtherButtonTitleKey { get; }

		// extern const CFStringRef kCFUserNotificationProgressIndicatorValueKey __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 0)]
		[Field ("kCFUserNotificationProgressIndicatorValueKey", "__Internal")]
		unsafe CFStringRef* kCFUserNotificationProgressIndicatorValueKey { get; }

		// extern const CFStringRef kCFUserNotificationPopUpTitlesKey __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 0)]
		[Field ("kCFUserNotificationPopUpTitlesKey", "__Internal")]
		unsafe CFStringRef* kCFUserNotificationPopUpTitlesKey { get; }

		// extern const CFStringRef kCFUserNotificationTextFieldTitlesKey __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 0)]
		[Field ("kCFUserNotificationTextFieldTitlesKey", "__Internal")]
		unsafe CFStringRef* kCFUserNotificationTextFieldTitlesKey { get; }

		// extern const CFStringRef kCFUserNotificationCheckBoxTitlesKey __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 0)]
		[Field ("kCFUserNotificationCheckBoxTitlesKey", "__Internal")]
		unsafe CFStringRef* kCFUserNotificationCheckBoxTitlesKey { get; }

		// extern const CFStringRef kCFUserNotificationTextFieldValuesKey __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 0)]
		[Field ("kCFUserNotificationTextFieldValuesKey", "__Internal")]
		unsafe CFStringRef* kCFUserNotificationTextFieldValuesKey { get; }

		// extern const CFStringRef kCFUserNotificationPopUpSelectionKey __attribute__((availability(macos, introduced=10.3))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 3)]
		[Field ("kCFUserNotificationPopUpSelectionKey", "__Internal")]
		unsafe CFStringRef* kCFUserNotificationPopUpSelectionKey { get; }

		// extern const CFStringRef kCFUserNotificationAlertTopMostKey __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 0)]
		[Field ("kCFUserNotificationAlertTopMostKey", "__Internal")]
		unsafe CFStringRef* kCFUserNotificationAlertTopMostKey { get; }

		// extern const CFStringRef kCFUserNotificationKeyboardTypesKey __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 0)]
		[Field ("kCFUserNotificationKeyboardTypesKey", "__Internal")]
		unsafe CFStringRef* kCFUserNotificationKeyboardTypesKey { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CGPoint CGPointZero __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 0), iOS (2, 0)]
		[Field ("CGPointZero", "__Internal")]
		CGPoint CGPointZero { get; }

		// extern const CGSize CGSizeZero __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 0), iOS (2, 0)]
		[Field ("CGSizeZero", "__Internal")]
		CGSize CGSizeZero { get; }

		// extern const CGRect CGRectZero __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 0), iOS (2, 0)]
		[Field ("CGRectZero", "__Internal")]
		CGRect CGRectZero { get; }

		// extern const CGRect CGRectNull __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 0), iOS (2, 0)]
		[Field ("CGRectNull", "__Internal")]
		CGRect CGRectNull { get; }

		// extern const CGRect CGRectInfinite __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 4), iOS (2, 0)]
		[Field ("CGRectInfinite", "__Internal")]
		CGRect CGRectInfinite { get; }

		// extern const CGAffineTransform CGAffineTransformIdentity __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 0), iOS (2, 0)]
		[Field ("CGAffineTransformIdentity", "__Internal")]
		CGAffineTransform CGAffineTransformIdentity { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef _Nonnull kCGColorSpaceGenericGray __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, introduced=9.0)));
		[Mac (10, 4), iOS (9, 0)]
		[Field ("kCGColorSpaceGenericGray", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceGenericGray { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceGenericRGB __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, introduced=9.0)));
		[Mac (10, 4), iOS (9, 0)]
		[Field ("kCGColorSpaceGenericRGB", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceGenericRGB { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceGenericCMYK __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, introduced=9.0)));
		[Mac (10, 4), iOS (9, 0)]
		[Field ("kCGColorSpaceGenericCMYK", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceGenericCMYK { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceDisplayP3 __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.11.2))) __attribute__((availability(ios, introduced=9.3)));
		[Mac (10, 11, 2), iOS (9, 3)]
		[Field ("kCGColorSpaceDisplayP3", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceDisplayP3 { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceGenericRGBLinear __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=9.0)));
		[Mac (10, 5), iOS (9, 0)]
		[Field ("kCGColorSpaceGenericRGBLinear", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceGenericRGBLinear { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceAdobeRGB1998 __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=9.0)));
		[Mac (10, 5), iOS (9, 0)]
		[Field ("kCGColorSpaceAdobeRGB1998", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceAdobeRGB1998 { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceSRGB __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=9.0)));
		[Mac (10, 5), iOS (9, 0)]
		[Field ("kCGColorSpaceSRGB", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceSRGB { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceGenericGrayGamma2_2 __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=9.0)));
		[Mac (10, 6), iOS (9, 0)]
		[Field ("kCGColorSpaceGenericGrayGamma2_2", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceGenericGrayGamma2_2 { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceGenericXYZ __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0)));
		[Mac (10, 11), iOS (9, 0)]
		[Field ("kCGColorSpaceGenericXYZ", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceGenericXYZ { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceGenericLab __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0)));
		[Mac (10, 13), iOS (11, 0)]
		[Field ("kCGColorSpaceGenericLab", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceGenericLab { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceACESCGLinear __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0)));
		[Mac (10, 11), iOS (9, 0)]
		[Field ("kCGColorSpaceACESCGLinear", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceACESCGLinear { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceITUR_709 __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0)));
		[Mac (10, 11), iOS (9, 0)]
		[Field ("kCGColorSpaceITUR_709", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceITUR_709 { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceITUR_709_PQ __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=12.0))) __attribute__((availability(ios, introduced=15.1)));
		[Mac (12, 0), iOS (15, 1)]
		[Field ("kCGColorSpaceITUR_709_PQ", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceITUR_709_PQ { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceITUR_709_HLG __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=12.0))) __attribute__((availability(ios, introduced=15.1)));
		[Mac (12, 0), iOS (15, 1)]
		[Field ("kCGColorSpaceITUR_709_HLG", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceITUR_709_HLG { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceITUR_2020 __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0)));
		[Mac (10, 11), iOS (9, 0)]
		[Field ("kCGColorSpaceITUR_2020", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceITUR_2020 { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceITUR_2020_sRGBGamma __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=12.0))) __attribute__((availability(ios, introduced=15.1)));
		[Mac (12, 0), iOS (15, 1)]
		[Field ("kCGColorSpaceITUR_2020_sRGBGamma", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceITUR_2020_sRGBGamma { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceROMMRGB __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0)));
		[Mac (10, 11), iOS (9, 0)]
		[Field ("kCGColorSpaceROMMRGB", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceROMMRGB { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceDCIP3 __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0)));
		[Mac (10, 11), iOS (9, 0)]
		[Field ("kCGColorSpaceDCIP3", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceDCIP3 { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceLinearITUR_2020 __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=12.0))) __attribute__((availability(ios, introduced=15.0)));
		[Mac (12, 0), iOS (15, 0)]
		[Field ("kCGColorSpaceLinearITUR_2020", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceLinearITUR_2020 { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceExtendedITUR_2020 __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, introduced=14.0)));
		[Mac (11, 0), iOS (14, 0)]
		[Field ("kCGColorSpaceExtendedITUR_2020", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceExtendedITUR_2020 { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceExtendedLinearITUR_2020 __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.14.3))) __attribute__((availability(ios, introduced=12.3)));
		[Mac (10, 14, 3), iOS (12, 3)]
		[Field ("kCGColorSpaceExtendedLinearITUR_2020", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceExtendedLinearITUR_2020 { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceLinearDisplayP3 __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=12.0))) __attribute__((availability(ios, introduced=15.0)));
		[Mac (12, 0), iOS (15, 0)]
		[Field ("kCGColorSpaceLinearDisplayP3", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceLinearDisplayP3 { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceExtendedDisplayP3 __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, introduced=14.0)));
		[Mac (11, 0), iOS (14, 0)]
		[Field ("kCGColorSpaceExtendedDisplayP3", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceExtendedDisplayP3 { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceExtendedLinearDisplayP3 __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.14.3))) __attribute__((availability(ios, introduced=12.3)));
		[Mac (10, 14, 3), iOS (12, 3)]
		[Field ("kCGColorSpaceExtendedLinearDisplayP3", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceExtendedLinearDisplayP3 { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceITUR_2100_PQ __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, introduced=14.0)));
		[Mac (11, 0), iOS (14, 0)]
		[Field ("kCGColorSpaceITUR_2100_PQ", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceITUR_2100_PQ { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceITUR_2100_HLG __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, introduced=14.0)));
		[Mac (11, 0), iOS (14, 0)]
		[Field ("kCGColorSpaceITUR_2100_HLG", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceITUR_2100_HLG { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceDisplayP3_PQ __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.15.4))) __attribute__((availability(ios, introduced=13.4)));
		[Mac (10, 15, 4), iOS (13, 4)]
		[Field ("kCGColorSpaceDisplayP3_PQ", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceDisplayP3_PQ { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceDisplayP3_HLG __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.14.6))) __attribute__((availability(ios, introduced=12.6)));
		[Mac (10, 14, 6), iOS (12, 6)]
		[Field ("kCGColorSpaceDisplayP3_HLG", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceDisplayP3_HLG { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceITUR_2020_PQ __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.15.4, deprecated=11.0))) __attribute__((availability(ios, introduced=13.4, deprecated=14.0)));
		[Introduced (PlatformName.MacOSX, 10, 15, 4, message: "No longer supported")]
		[Deprecated (PlatformName.MacOSX, 11, 0, message: "No longer supported")]
		[Introduced (PlatformName.iOS, 13, 4, message: "No longer supported")]
		[Deprecated (PlatformName.iOS, 14, 0, message: "No longer supported")]
		[Field ("kCGColorSpaceITUR_2020_PQ", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceITUR_2020_PQ { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceITUR_2020_HLG __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.15.6, deprecated=11.0))) __attribute__((availability(ios, introduced=12.6, deprecated=14.0)));
		[Introduced (PlatformName.MacOSX, 10, 15, 6, message: "No longer supported")]
		[Deprecated (PlatformName.MacOSX, 11, 0, message: "No longer supported")]
		[Introduced (PlatformName.iOS, 12, 6, message: "No longer supported")]
		[Deprecated (PlatformName.iOS, 14, 0, message: "No longer supported")]
		[Field ("kCGColorSpaceITUR_2020_HLG", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceITUR_2020_HLG { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceDisplayP3_PQ_EOTF __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.14.6, deprecated=10.15.4))) __attribute__((availability(ios, introduced=12.6, deprecated=13.4)));
		[Introduced (PlatformName.MacOSX, 10, 14, 6, message: "No longer supported")]
		[Deprecated (PlatformName.MacOSX, 10, 15, 4, message: "No longer supported")]
		[Introduced (PlatformName.iOS, 12, 6, message: "No longer supported")]
		[Deprecated (PlatformName.iOS, 13, 4, message: "No longer supported")]
		[Field ("kCGColorSpaceDisplayP3_PQ_EOTF", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceDisplayP3_PQ_EOTF { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceITUR_2020_PQ_EOTF __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.14.6, deprecated=10.15.4))) __attribute__((availability(ios, introduced=12.6, deprecated=13.4)));
		[Introduced (PlatformName.MacOSX, 10, 14, 6, message: "No longer supported")]
		[Deprecated (PlatformName.MacOSX, 10, 15, 4, message: "No longer supported")]
		[Introduced (PlatformName.iOS, 12, 6, message: "No longer supported")]
		[Deprecated (PlatformName.iOS, 13, 4, message: "No longer supported")]
		[Field ("kCGColorSpaceITUR_2020_PQ_EOTF", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceITUR_2020_PQ_EOTF { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceExtendedSRGB __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0)));
		[Mac (10, 12), iOS (10, 0)]
		[Field ("kCGColorSpaceExtendedSRGB", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceExtendedSRGB { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceLinearSRGB __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0)));
		[Mac (10, 12), iOS (10, 0)]
		[Field ("kCGColorSpaceLinearSRGB", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceLinearSRGB { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceExtendedLinearSRGB __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0)));
		[Mac (10, 12), iOS (10, 0)]
		[Field ("kCGColorSpaceExtendedLinearSRGB", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceExtendedLinearSRGB { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceExtendedGray __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0)));
		[Mac (10, 12), iOS (10, 0)]
		[Field ("kCGColorSpaceExtendedGray", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceExtendedGray { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceLinearGray __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0)));
		[Mac (10, 12), iOS (10, 0)]
		[Field ("kCGColorSpaceLinearGray", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceLinearGray { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceExtendedLinearGray __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0)));
		[Mac (10, 12), iOS (10, 0)]
		[Field ("kCGColorSpaceExtendedLinearGray", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceExtendedLinearGray { get; }

		// extern const CFStringRef _Nonnull kCGColorSpaceExtendedRange __attribute__((visibility("default")));
		[Field ("kCGColorSpaceExtendedRange", "__Internal")]
		unsafe CFStringRef* kCGColorSpaceExtendedRange { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef _Nonnull kCGColorWhite __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=14.0)));
		[Mac (10, 5), iOS (14, 0)]
		[Field ("kCGColorWhite", "__Internal")]
		unsafe CFStringRef* kCGColorWhite { get; }

		// extern const CFStringRef _Nonnull kCGColorBlack __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=14.0)));
		[Mac (10, 5), iOS (14, 0)]
		[Field ("kCGColorBlack", "__Internal")]
		unsafe CFStringRef* kCGColorBlack { get; }

		// extern const CFStringRef _Nonnull kCGColorClear __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=14.0)));
		[Mac (10, 5), iOS (14, 0)]
		[Field ("kCGColorClear", "__Internal")]
		unsafe CFStringRef* kCGColorClear { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef _Nonnull kCGFontVariationAxisName __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 4), iOS (2, 0)]
		[Field ("kCGFontVariationAxisName", "__Internal")]
		unsafe CFStringRef* kCGFontVariationAxisName { get; }

		// extern const CFStringRef _Nonnull kCGFontVariationAxisMinValue __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 4), iOS (2, 0)]
		[Field ("kCGFontVariationAxisMinValue", "__Internal")]
		unsafe CFStringRef* kCGFontVariationAxisMinValue { get; }

		// extern const CFStringRef _Nonnull kCGFontVariationAxisMaxValue __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 4), iOS (2, 0)]
		[Field ("kCGFontVariationAxisMaxValue", "__Internal")]
		unsafe CFStringRef* kCGFontVariationAxisMaxValue { get; }

		// extern const CFStringRef _Nonnull kCGFontVariationAxisDefaultValue __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 4), iOS (2, 0)]
		[Field ("kCGFontVariationAxisDefaultValue", "__Internal")]
		unsafe CFStringRef* kCGFontVariationAxisDefaultValue { get; }
	}

	// typedef void (^CGPathApplyBlock)(const CGPathElement * _Nonnull);
	unsafe delegate void CGPathApplyBlock (CGPathElement* arg0);

	// typedef _Bool (^CGPDFArrayApplierBlock)(size_t, CGPDFObjectRef _Nonnull, void * _Nullable);
	unsafe delegate bool CGPDFArrayApplierBlock (nuint arg0, CGPDFObjectRef* arg1, [NullAllowed] void* arg2);

	// typedef _Bool (^CGPDFDictionaryApplierBlock)(const char * _Nonnull, CGPDFObjectRef _Nonnull, void * _Nullable);
	unsafe delegate bool CGPDFDictionaryApplierBlock (sbyte* arg0, CGPDFObjectRef* arg1, [NullAllowed] void* arg2);

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef _Nonnull kCGPDFOutlineTitle __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0)));
		[Mac (10, 13), iOS (11, 0)]
		[Field ("kCGPDFOutlineTitle", "__Internal")]
		unsafe CFStringRef* kCGPDFOutlineTitle { get; }

		// extern const CFStringRef _Nonnull kCGPDFOutlineChildren __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0)));
		[Mac (10, 13), iOS (11, 0)]
		[Field ("kCGPDFOutlineChildren", "__Internal")]
		unsafe CFStringRef* kCGPDFOutlineChildren { get; }

		// extern const CFStringRef _Nonnull kCGPDFOutlineDestination __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0)));
		[Mac (10, 13), iOS (11, 0)]
		[Field ("kCGPDFOutlineDestination", "__Internal")]
		unsafe CFStringRef* kCGPDFOutlineDestination { get; }

		// extern const CFStringRef _Nonnull kCGPDFOutlineDestinationRect __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0)));
		[Mac (10, 13), iOS (11, 0)]
		[Field ("kCGPDFOutlineDestinationRect", "__Internal")]
		unsafe CFStringRef* kCGPDFOutlineDestinationRect { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef _Nonnull kCGColorConversionBlackPointCompensation __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0)));
		[Mac (10, 12), iOS (10, 0)]
		[Field ("kCGColorConversionBlackPointCompensation", "__Internal")]
		unsafe CFStringRef* kCGColorConversionBlackPointCompensation { get; }

		// extern const CFStringRef _Nonnull kCGColorConversionTRCSize __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0)));
		[Mac (10, 13), iOS (11, 0)]
		[Field ("kCGColorConversionTRCSize", "__Internal")]
		unsafe CFStringRef* kCGColorConversionTRCSize { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef _Nonnull kCGPDFContextMediaBox __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 4), iOS (2, 0)]
		[Field ("kCGPDFContextMediaBox", "__Internal")]
		unsafe CFStringRef* kCGPDFContextMediaBox { get; }

		// extern const CFStringRef _Nonnull kCGPDFContextCropBox __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 4), iOS (2, 0)]
		[Field ("kCGPDFContextCropBox", "__Internal")]
		unsafe CFStringRef* kCGPDFContextCropBox { get; }

		// extern const CFStringRef _Nonnull kCGPDFContextBleedBox __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 4), iOS (2, 0)]
		[Field ("kCGPDFContextBleedBox", "__Internal")]
		unsafe CFStringRef* kCGPDFContextBleedBox { get; }

		// extern const CFStringRef _Nonnull kCGPDFContextTrimBox __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 4), iOS (2, 0)]
		[Field ("kCGPDFContextTrimBox", "__Internal")]
		unsafe CFStringRef* kCGPDFContextTrimBox { get; }

		// extern const CFStringRef _Nonnull kCGPDFContextArtBox __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 4), iOS (2, 0)]
		[Field ("kCGPDFContextArtBox", "__Internal")]
		unsafe CFStringRef* kCGPDFContextArtBox { get; }

		// extern const CFStringRef _Nonnull kCGPDFContextTitle __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 4), iOS (2, 0)]
		[Field ("kCGPDFContextTitle", "__Internal")]
		unsafe CFStringRef* kCGPDFContextTitle { get; }

		// extern const CFStringRef _Nonnull kCGPDFContextAuthor __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 4), iOS (2, 0)]
		[Field ("kCGPDFContextAuthor", "__Internal")]
		unsafe CFStringRef* kCGPDFContextAuthor { get; }

		// extern const CFStringRef _Nonnull kCGPDFContextSubject __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 5), iOS (2, 0)]
		[Field ("kCGPDFContextSubject", "__Internal")]
		unsafe CFStringRef* kCGPDFContextSubject { get; }

		// extern const CFStringRef _Nonnull kCGPDFContextKeywords __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 5), iOS (2, 0)]
		[Field ("kCGPDFContextKeywords", "__Internal")]
		unsafe CFStringRef* kCGPDFContextKeywords { get; }

		// extern const CFStringRef _Nonnull kCGPDFContextCreator __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 4), iOS (2, 0)]
		[Field ("kCGPDFContextCreator", "__Internal")]
		unsafe CFStringRef* kCGPDFContextCreator { get; }

		// extern const CFStringRef _Nonnull kCGPDFContextOwnerPassword __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 4), iOS (2, 0)]
		[Field ("kCGPDFContextOwnerPassword", "__Internal")]
		unsafe CFStringRef* kCGPDFContextOwnerPassword { get; }

		// extern const CFStringRef _Nonnull kCGPDFContextUserPassword __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 4), iOS (2, 0)]
		[Field ("kCGPDFContextUserPassword", "__Internal")]
		unsafe CFStringRef* kCGPDFContextUserPassword { get; }

		// extern const CFStringRef _Nonnull kCGPDFContextEncryptionKeyLength __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 5), iOS (2, 0)]
		[Field ("kCGPDFContextEncryptionKeyLength", "__Internal")]
		unsafe CFStringRef* kCGPDFContextEncryptionKeyLength { get; }

		// extern const CFStringRef _Nonnull kCGPDFContextAllowsPrinting __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 4), iOS (2, 0)]
		[Field ("kCGPDFContextAllowsPrinting", "__Internal")]
		unsafe CFStringRef* kCGPDFContextAllowsPrinting { get; }

		// extern const CFStringRef _Nonnull kCGPDFContextAllowsCopying __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 4), iOS (2, 0)]
		[Field ("kCGPDFContextAllowsCopying", "__Internal")]
		unsafe CFStringRef* kCGPDFContextAllowsCopying { get; }

		// extern const CFStringRef _Nonnull kCGPDFContextOutputIntent __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, introduced=14.0)));
		[Mac (10, 4), iOS (14, 0)]
		[Field ("kCGPDFContextOutputIntent", "__Internal")]
		unsafe CFStringRef* kCGPDFContextOutputIntent { get; }

		// extern const CFStringRef _Nonnull kCGPDFXOutputIntentSubtype __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, introduced=14.0)));
		[Mac (10, 4), iOS (14, 0)]
		[Field ("kCGPDFXOutputIntentSubtype", "__Internal")]
		unsafe CFStringRef* kCGPDFXOutputIntentSubtype { get; }

		// extern const CFStringRef _Nonnull kCGPDFXOutputConditionIdentifier __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, introduced=14.0)));
		[Mac (10, 4), iOS (14, 0)]
		[Field ("kCGPDFXOutputConditionIdentifier", "__Internal")]
		unsafe CFStringRef* kCGPDFXOutputConditionIdentifier { get; }

		// extern const CFStringRef _Nonnull kCGPDFXOutputCondition __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, introduced=14.0)));
		[Mac (10, 4), iOS (14, 0)]
		[Field ("kCGPDFXOutputCondition", "__Internal")]
		unsafe CFStringRef* kCGPDFXOutputCondition { get; }

		// extern const CFStringRef _Nonnull kCGPDFXRegistryName __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, introduced=14.0)));
		[Mac (10, 4), iOS (14, 0)]
		[Field ("kCGPDFXRegistryName", "__Internal")]
		unsafe CFStringRef* kCGPDFXRegistryName { get; }

		// extern const CFStringRef _Nonnull kCGPDFXInfo __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, introduced=14.0)));
		[Mac (10, 4), iOS (14, 0)]
		[Field ("kCGPDFXInfo", "__Internal")]
		unsafe CFStringRef* kCGPDFXInfo { get; }

		// extern const CFStringRef _Nonnull kCGPDFXDestinationOutputProfile __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, introduced=14.0)));
		[Mac (10, 4), iOS (14, 0)]
		[Field ("kCGPDFXDestinationOutputProfile", "__Internal")]
		unsafe CFStringRef* kCGPDFXDestinationOutputProfile { get; }

		// extern const CFStringRef _Nonnull kCGPDFContextOutputIntents __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, introduced=14.0)));
		[Mac (10, 4), iOS (14, 0)]
		[Field ("kCGPDFContextOutputIntents", "__Internal")]
		unsafe CFStringRef* kCGPDFContextOutputIntents { get; }

		// extern const CFStringRef _Nonnull kCGPDFContextAccessPermissions __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0)));
		[Mac (10, 13), iOS (11, 0)]
		[Field ("kCGPDFContextAccessPermissions", "__Internal")]
		unsafe CFStringRef* kCGPDFContextAccessPermissions { get; }

		// extern const CFStringRef _Nonnull kCGPDFContextCreateLinearizedPDF __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, introduced=14.0)));
		[Mac (11, 0), iOS (14, 0)]
		[Field ("kCGPDFContextCreateLinearizedPDF", "__Internal")]
		unsafe CFStringRef* kCGPDFContextCreateLinearizedPDF { get; }

		// extern const CFStringRef _Nonnull kCGPDFContextCreatePDFA __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, introduced=14.0)));
		[Mac (11, 0), iOS (14, 0)]
		[Field ("kCGPDFContextCreatePDFA", "__Internal")]
		unsafe CFStringRef* kCGPDFContextCreatePDFA { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern CGPDFTagProperty  _Nonnull const kCGPDFTagPropertyActualText __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
		[Mac (10, 15), iOS (13, 0)]
		[Field ("kCGPDFTagPropertyActualText", "__Internal")]
		unsafe CGPDFTagProperty* kCGPDFTagPropertyActualText { get; }

		// extern CGPDFTagProperty  _Nonnull const kCGPDFTagPropertyAlternativeText __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
		[Mac (10, 15), iOS (13, 0)]
		[Field ("kCGPDFTagPropertyAlternativeText", "__Internal")]
		unsafe CGPDFTagProperty* kCGPDFTagPropertyAlternativeText { get; }

		// extern CGPDFTagProperty  _Nonnull const kCGPDFTagPropertyTitleText __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
		[Mac (10, 15), iOS (13, 0)]
		[Field ("kCGPDFTagPropertyTitleText", "__Internal")]
		unsafe CGPDFTagProperty* kCGPDFTagPropertyTitleText { get; }

		// extern CGPDFTagProperty  _Nonnull const kCGPDFTagPropertyLanguageText __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
		[Mac (10, 15), iOS (13, 0)]
		[Field ("kCGPDFTagPropertyLanguageText", "__Internal")]
		unsafe CGPDFTagProperty* kCGPDFTagPropertyLanguageText { get; }
	}

	// @protocol LROLifecycleDelegate
	[Protocol, Model (AutoGeneratedName = true)]
	interface LROLifecycleDelegate
	{
		// @required -(void)viewControllerDidAppear:(UIViewController * _Nonnull)_;
		[Abstract]
		[Export ("viewControllerDidAppear:")]
		void ViewControllerDidAppear (UIViewController _);

		// @required -(void)viewControllerDidDisappear:(UIViewController * _Nonnull)_;
		[Abstract]
		[Export ("viewControllerDidDisappear:")]
		void ViewControllerDidDisappear (UIViewController _);
	}

	// @interface LROApplicationLifecycleObserver : NSObject <LROLifecycleDelegate>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface LROApplicationLifecycleObserver : ILROLifecycleDelegate
	{
		// -(void)viewControllerDidAppear:(UIViewController * _Nonnull)viewController;
		[Export ("viewControllerDidAppear:")]
		void ViewControllerDidAppear (UIViewController viewController);

		// -(void)viewControllerDidDisappear:(UIViewController * _Nonnull)viewController;
		[Export ("viewControllerDidDisappear:")]
		void ViewControllerDidDisappear (UIViewController viewController);
	}

	// @interface LROCaptureMessageBuilder : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface LROCaptureMessageBuilder
	{
		// -(instancetype _Nonnull)init:(NSString * _Nonnull)message __attribute__((objc_designated_initializer));
		[Export ("init:")]
		[DesignatedInitializer]
		IntPtr Constructor (string message);

		// -(LROCaptureMessageBuilder * _Nonnull)putTagString:(NSString * _Nonnull)key value:(NSString * _Nonnull)value __attribute__((warn_unused_result));
		[Export ("putTagString:value:")]
		LROCaptureMessageBuilder PutTagString (string key, string value);

		// -(LROCaptureMessageBuilder * _Nonnull)putTagBoolean:(NSString * _Nonnull)key value:(BOOL)value __attribute__((warn_unused_result));
		[Export ("putTagBoolean:value:")]
		LROCaptureMessageBuilder PutTagBoolean (string key, bool value);

		// -(LROCaptureMessageBuilder * _Nonnull)putTagDouble:(NSString * _Nonnull)key value:(double)value __attribute__((warn_unused_result));
		[Export ("putTagDouble:value:")]
		LROCaptureMessageBuilder PutTagDouble (string key, double value);

		// -(LROCaptureMessageBuilder * _Nonnull)putTagInt:(NSString * _Nonnull)key value:(NSInteger)value __attribute__((warn_unused_result));
		[Export ("putTagInt:value:")]
		LROCaptureMessageBuilder PutTagInt (string key, nint value);

		// -(LROCaptureMessageBuilder * _Nonnull)putExtraString:(NSString * _Nonnull)key value:(NSString * _Nonnull)value __attribute__((warn_unused_result));
		[Export ("putExtraString:value:")]
		LROCaptureMessageBuilder PutExtraString (string key, string value);

		// -(LROCaptureMessageBuilder * _Nonnull)putExtraBoolean:(NSString * _Nonnull)key value:(BOOL)value __attribute__((warn_unused_result));
		[Export ("putExtraBoolean:value:")]
		LROCaptureMessageBuilder PutExtraBoolean (string key, bool value);

		// -(LROCaptureMessageBuilder * _Nonnull)putExtraDouble:(NSString * _Nonnull)key value:(double)value __attribute__((warn_unused_result));
		[Export ("putExtraDouble:value:")]
		LROCaptureMessageBuilder PutExtraDouble (string key, double value);

		// -(LROCaptureMessageBuilder * _Nonnull)putExtraInt:(NSString * _Nonnull)key value:(NSInteger)value __attribute__((warn_unused_result));
		[Export ("putExtraInt:value:")]
		LROCaptureMessageBuilder PutExtraInt (string key, nint value);
	}

	// @interface LROConfiguration : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface LROConfiguration
	{
		// @property (copy, nonatomic) NSString * _Nonnull serverURL;
		[Export ("serverURL")]
		string ServerURL { get; set; }

		// @property (nonatomic, strong) NSMutableSet * _Nonnull allowTags;
		[Export ("allowTags", ArgumentSemantic.Strong)]
		NSMutableSet AllowTags { get; set; }

		// @property (nonatomic, strong) NSMutableSet * _Nonnull redactionTags;
		[Export ("redactionTags", ArgumentSemantic.Strong)]
		NSMutableSet RedactionTags { get; set; }

		// @property (nonatomic, strong) NSMutableSet * _Nonnull inputRedactionTags;
		[Export ("inputRedactionTags", ArgumentSemantic.Strong)]
		NSMutableSet InputRedactionTags { get; set; }

		// @property (nonatomic) enum LROSanitizerType textSanitizer;
		[Export ("textSanitizer", ArgumentSemantic.Assign)]
		LROSanitizerType TextSanitizer { get; set; }

		// @property (nonatomic) BOOL redactMenus;
		[Export ("redactMenus")]
		bool RedactMenus { get; set; }

		// @property (nonatomic) BOOL viewScanningEnabled;
		[Export ("viewScanningEnabled")]
		bool ViewScanningEnabled { get; set; }

		// @property (nonatomic) BOOL networkCaptureEnabled;
		[Export ("networkCaptureEnabled")]
		bool NetworkCaptureEnabled { get; set; }

		// @property (nonatomic) BOOL logCaptureEnabled;
		[Export ("logCaptureEnabled")]
		bool LogCaptureEnabled { get; set; }

		// @property (nonatomic, strong) id<LRORequestSanitizer> _Nullable requestSanitizer;
		[NullAllowed, Export ("requestSanitizer", ArgumentSemantic.Strong)]
		LRORequestSanitizer RequestSanitizer { get; set; }

		// @property (nonatomic, strong) id<LROResponseSanitizer> _Nullable responseSanitizer;
		[NullAllowed, Export ("responseSanitizer", ArgumentSemantic.Strong)]
		LROResponseSanitizer ResponseSanitizer { get; set; }

		// @property (nonatomic) BOOL registerTouchHandlers;
		[Export ("registerTouchHandlers")]
		bool RegisterTouchHandlers { get; set; }

		// @property (nonatomic) CGFloat scaleFactor;
		[Export ("scaleFactor")]
		nfloat ScaleFactor { get; set; }

		// @property (nonatomic) BOOL ipCaptureEnabled;
		[Export ("ipCaptureEnabled")]
		bool IpCaptureEnabled { get; set; }

		// @property (nonatomic) BOOL persistenceEnabled;
		[Export ("persistenceEnabled")]
		bool PersistenceEnabled { get; set; }

		// @property (nonatomic) uint32_t bufferTimeoutSeconds;
		[Export ("bufferTimeoutSeconds")]
		uint BufferTimeoutSeconds { get; set; }

		// @property (nonatomic) NSInteger uploadIntervalMs;
		[Export ("uploadIntervalMs")]
		nint UploadIntervalMs { get; set; }

		// @property (nonatomic, strong) LROProxyConfigurationBuilder * _Nonnull proxyConfiguration;
		[Export ("proxyConfiguration", ArgumentSemantic.Strong)]
		LROProxyConfigurationBuilder ProxyConfiguration { get; set; }

		// @property (nonatomic) BOOL experimentalBidiCapture;
		[Export ("experimentalBidiCapture")]
		bool ExperimentalBidiCapture { get; set; }

		// -(instancetype _Nonnull)initWithAppID:(NSString * _Nonnull)appID __attribute__((objc_designated_initializer));
		[Export ("initWithAppID:")]
		[DesignatedInitializer]
		IntPtr Constructor (string appID);
	}

	// @interface LROCustomEvent : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface LROCustomEvent
	{
	}

	// @interface LROCustomEventBuilder : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface LROCustomEventBuilder
	{
		// -(instancetype _Nonnull)init:(NSString * _Nonnull)name __attribute__((objc_designated_initializer));
		[Export ("init:")]
		[DesignatedInitializer]
		IntPtr Constructor (string name);

		// -(void)putRevenue:(double)value;
		[Export ("putRevenue:")]
		void PutRevenue (double value);

		// -(void)putString:(NSString * _Nonnull)key value:(NSString * _Nonnull)value;
		[Export ("putString:value:")]
		void PutString (string key, string value);

		// -(void)putStringArray:(NSString * _Nonnull)key value:(NSArray * _Nonnull)value;
		[Export ("putStringArray:value:")]
		[Verify (StronglyTypedNSArray)]
		void PutStringArray (string key, NSObject[] value);

		// -(void)putDouble:(NSString * _Nonnull)key value:(double)value;
		[Export ("putDouble:value:")]
		void PutDouble (string key, double value);

		// -(void)putDoubleArray:(NSString * _Nonnull)key value:(NSArray * _Nonnull)value;
		[Export ("putDoubleArray:value:")]
		[Verify (StronglyTypedNSArray)]
		void PutDoubleArray (string key, NSObject[] value);

		// -(void)putBool:(NSString * _Nonnull)key value:(BOOL)value;
		[Export ("putBool:value:")]
		void PutBool (string key, bool value);

		// -(void)putBoolArray:(NSString * _Nonnull)key value:(NSArray * _Nonnull)value;
		[Export ("putBoolArray:value:")]
		[Verify (StronglyTypedNSArray)]
		void PutBoolArray (string key, NSObject[] value);
	}

	// @interface LRMarkerUIView
	[DisableDefaultCtor]
	interface LRMarkerUIView
	{
		// -(void)didMoveToWindow;
		[Export ("didMoveToWindow")]
		void DidMoveToWindow ();
	}

	// @interface LROLogHandler : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface LROLogHandler
	{
		// +(void)swift_load;
		[Static]
		[Export ("swift_load")]
		void Swift_load ();
	}

	// @interface LROScrollTracker : NSObject
	[BaseType (typeof(NSObject))]
	interface LROScrollTracker
	{
		// -(void)scrollViewWillBeginDragging:(UIScrollView * _Nonnull)view;
		[Export ("scrollViewWillBeginDragging:")]
		void ScrollViewWillBeginDragging (UIScrollView view);

		// -(void)scrollViewDidEndDecelerating:(UIScrollView * _Nonnull)view;
		[Export ("scrollViewDidEndDecelerating:")]
		void ScrollViewDidEndDecelerating (UIScrollView view);

		// -(void)scrollViewDidEndDragging:(UIScrollView * _Nonnull)view willDecelerate:(BOOL)decelerate;
		[Export ("scrollViewDidEndDragging:willDecelerate:")]
		void ScrollViewDidEndDragging (UIScrollView view, bool decelerate);
	}

	// @interface LROLogger : NSObject
	[BaseType (typeof(NSObject))]
	interface LROLogger
	{
		// +(void)debugWithMessage:(NSString * _Nonnull)message;
		[Static]
		[Export ("debugWithMessage:")]
		void DebugWithMessage (string message);

		// +(void)infoWithMessage:(NSString * _Nonnull)message;
		[Static]
		[Export ("infoWithMessage:")]
		void InfoWithMessage (string message);

		// +(void)errorWithMessage:(NSString * _Nonnull)message;
		[Static]
		[Export ("errorWithMessage:")]
		void ErrorWithMessage (string message);

		// +(void)warningWithMessage:(NSString * _Nonnull)message;
		[Static]
		[Export ("warningWithMessage:")]
		void WarningWithMessage (string message);
	}

	// @interface LROProxyConfigurationBuilder : NSObject
	[BaseType (typeof(NSObject))]
	interface LROProxyConfigurationBuilder
	{
		// -(void)proxyUsername:(NSString * _Nonnull)username;
		[Export ("proxyUsername:")]
		void ProxyUsername (string username);

		// -(void)proxyPassword:(NSString * _Nonnull)password;
		[Export ("proxyPassword:")]
		void ProxyPassword (string password);

		// -(void)httpEnable:(BOOL)enable;
		[Export ("httpEnable:")]
		void HttpEnable (bool enable);

		// -(void)httpProxy:(NSString * _Nonnull)proxy;
		[Export ("httpProxy:")]
		void HttpProxy (string proxy);

		// -(void)httpPort:(NSInteger)port;
		[Export ("httpPort:")]
		void HttpPort (nint port);
	}

	// @interface LRORequest : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface LRORequest
	{
		// @property (copy, nonatomic) NSString * _Nullable arsonBody;
		[NullAllowed, Export ("arsonBody")]
		string ArsonBody { get; set; }

		// @property (copy, nonatomic) NSData * _Nullable body;
		[NullAllowed, Export ("body", ArgumentSemantic.Copy)]
		NSData Body { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nullable headers;
		[NullAllowed, Export ("headers", ArgumentSemantic.Copy)]
		NSDictionary Headers { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull method;
		[Export ("method")]
		string Method { get; }

		// @property (readonly, nonatomic) NSInteger reqID;
		[Export ("reqID")]
		nint ReqID { get; }

		// @property (copy, nonatomic) NSString * _Nullable url;
		[NullAllowed, Export ("url")]
		string Url { get; set; }
	}

	// @interface LRORequestBuilder : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface LRORequestBuilder
	{
		// @property (copy, nonatomic) NSString * _Nullable arsonBody;
		[NullAllowed, Export ("arsonBody")]
		string ArsonBody { get; set; }

		// @property (copy, nonatomic) NSData * _Nullable body;
		[NullAllowed, Export ("body", ArgumentSemantic.Copy)]
		NSData Body { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nonnull headers;
		[Export ("headers", ArgumentSemantic.Copy)]
		NSDictionary Headers { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable method;
		[NullAllowed, Export ("method")]
		string Method { get; set; }

		// @property (readonly, nonatomic) NSInteger reqID;
		[Export ("reqID")]
		nint ReqID { get; }

		// @property (copy, nonatomic) NSString * _Nullable url;
		[NullAllowed, Export ("url")]
		string Url { get; set; }

		// -(LROResponseBuilder * _Nullable)capture __attribute__((warn_unused_result));
		[NullAllowed, Export ("capture")]
		[Verify (MethodToProperty)]
		LROResponseBuilder Capture { get; }
	}

	// @protocol LRORequestSanitizer
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface LRORequestSanitizer
	{
		// @required -(LRORequest * _Nullable)sanitizeWithRequest:(LRORequest * _Nonnull)request __attribute__((warn_unused_result));
		[Abstract]
		[Export ("sanitizeWithRequest:")]
		[return: NullAllowed]
		LRORequest SanitizeWithRequest (LRORequest request);
	}

	// @interface LROResponse : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface LROResponse
	{
		// @property (copy, nonatomic) NSString * _Nullable arsonBody;
		[NullAllowed, Export ("arsonBody")]
		string ArsonBody { get; set; }

		// @property (copy, nonatomic) NSData * _Nullable body;
		[NullAllowed, Export ("body", ArgumentSemantic.Copy)]
		NSData Body { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nullable headers;
		[NullAllowed, Export ("headers", ArgumentSemantic.Copy)]
		NSDictionary Headers { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull method;
		[Export ("method")]
		string Method { get; }

		// @property (readonly, nonatomic) NSInteger reqID;
		[Export ("reqID")]
		nint ReqID { get; }

		// @property (readonly, nonatomic) uint32_t status;
		[Export ("status")]
		uint Status { get; }

		// @property (copy, nonatomic) NSString * _Nullable url;
		[NullAllowed, Export ("url")]
		string Url { get; set; }
	}

	// @interface LROResponseBuilder : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface LROResponseBuilder
	{
		// @property (copy, nonatomic) NSString * _Nullable arsonBody;
		[NullAllowed, Export ("arsonBody")]
		string ArsonBody { get; set; }

		// @property (copy, nonatomic) NSData * _Nullable body;
		[NullAllowed, Export ("body", ArgumentSemantic.Copy)]
		NSData Body { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nonnull headers;
		[Export ("headers", ArgumentSemantic.Copy)]
		NSDictionary Headers { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull method;
		[Export ("method")]
		string Method { get; set; }

		// @property (readonly, nonatomic) NSInteger reqID;
		[Export ("reqID")]
		nint ReqID { get; }

		// @property (nonatomic) NSInteger status;
		[Export ("status")]
		nint Status { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull url;
		[Export ("url")]
		string Url { get; set; }

		// @property (nonatomic) double duration;
		[Export ("duration")]
		double Duration { get; set; }

		// -(BOOL)capture __attribute__((warn_unused_result));
		[Export ("capture")]
		[Verify (MethodToProperty)]
		bool Capture { get; }
	}

	// @protocol LROResponseSanitizer
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface LROResponseSanitizer
	{
		// @required -(LROResponse * _Nullable)sanitizeWithResponse:(LROResponse * _Nonnull)response __attribute__((warn_unused_result));
		[Abstract]
		[Export ("sanitizeWithResponse:")]
		[return: NullAllowed]
		LROResponse SanitizeWithResponse (LROResponse response);
	}

	// @interface LROSDK : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface LROSDK
	{
		// +(BOOL)initializeInternalWithConfiguration:(LROConfiguration * _Nonnull)configuration __attribute__((warn_unused_result));
		[Static]
		[Export ("initializeInternalWithConfiguration:")]
		bool InitializeInternalWithConfiguration (LROConfiguration configuration);

		// +(void)initializeWithConfiguration:(LROConfiguration * _Nonnull)configuration;
		[Static]
		[Export ("initializeWithConfiguration:")]
		void InitializeWithConfiguration (LROConfiguration configuration);

		// +(void)addLogWithLevel:(NSString * _Nonnull)level args:(NSArray * _Nonnull)args;
		[Static]
		[Export ("addLogWithLevel:args:")]
		[Verify (StronglyTypedNSArray)]
		void AddLogWithLevel (string level, NSObject[] args);

		// +(void)captureExceptionWithErrorMessage:(NSString * _Nonnull)errorMessage errorType:(NSString * _Nonnull)errorType exceptionType:(NSString * _Nonnull)exceptionType stackTrace:(NSString * _Nonnull)stackTrace;
		[Static]
		[Export ("captureExceptionWithErrorMessage:errorType:exceptionType:stackTrace:")]
		void CaptureExceptionWithErrorMessage (string errorMessage, string errorType, string exceptionType, string stackTrace);

		// +(void)captureMessage:(LROCaptureMessageBuilder * _Nonnull)builder;
		[Static]
		[Export ("captureMessage:")]
		void CaptureMessage (LROCaptureMessageBuilder builder);

		// +(void)captureReduxActionWithAction:(NSString * _Nonnull)action storeId:(NSNumber * _Nonnull)storeId duration:(NSNumber * _Nonnull)duration stateDelta:(NSString * _Nonnull)stateDelta count:(NSNumber * _Nonnull)count;
		[Static]
		[Export ("captureReduxActionWithAction:storeId:duration:stateDelta:count:")]
		void CaptureReduxActionWithAction (string action, NSNumber storeId, NSNumber duration, string stateDelta, NSNumber count);

		// +(void)captureReduxInitialStateWithState:(NSString * _Nonnull)state storeId:(NSNumber * _Nonnull)storeId;
		[Static]
		[Export ("captureReduxInitialStateWithState:storeId:")]
		void CaptureReduxInitialStateWithState (string state, NSNumber storeId);

		// +(void)getSessionURL:(void (^ _Nonnull)(NSString * _Nonnull))completion;
		[Static]
		[Export ("getSessionURL:")]
		void GetSessionURL (Action<NSString> completion);

		// +(void)identifyWithUserID:(NSString * _Nonnull)userID userInfo:(NSDictionary * _Nullable)userInfo;
		[Static]
		[Export ("identifyWithUserID:userInfo:")]
		void IdentifyWithUserID (string userID, [NullAllowed] NSDictionary userInfo);

		// +(void)identifyAsAnonymousWithUserID:(NSString * _Nonnull)userID userInfo:(NSDictionary * _Nullable)userInfo;
		[Static]
		[Export ("identifyAsAnonymousWithUserID:userInfo:")]
		void IdentifyAsAnonymousWithUserID (string userID, [NullAllowed] NSDictionary userInfo);

		// +(LRORequestBuilder * _Nullable)newRequestBuilder __attribute__((warn_unused_result));
		[Static]
		[NullAllowed, Export ("newRequestBuilder")]
		[Verify (MethodToProperty)]
		LRORequestBuilder NewRequestBuilder { get; }

		// +(void)pauseViewCapture;
		[Static]
		[Export ("pauseViewCapture")]
		void PauseViewCapture ();

		// +(void)endSession;
		[Static]
		[Export ("endSession")]
		void EndSession ();

		// +(void)shutdown;
		[Static]
		[Export ("shutdown")]
		void Shutdown ();

		// +(void)hardShutdown;
		[Static]
		[Export ("hardShutdown")]
		void HardShutdown ();

		// +(void)track:(LROCustomEventBuilder * _Nonnull)builder;
		[Static]
		[Export ("track:")]
		void Track (LROCustomEventBuilder builder);

		// +(void)tagPage:(NSString * _Nonnull)relativePage;
		[Static]
		[Export ("tagPage:")]
		void TagPage (string relativePage);

		// +(void)unpauseViewCapture;
		[Static]
		[Export ("unpauseViewCapture")]
		void UnpauseViewCapture ();

		// +(void)viewControllerDidAppear:(UIViewController * _Nonnull)controller;
		[Static]
		[Export ("viewControllerDidAppear:")]
		void ViewControllerDidAppear (UIViewController controller);

		// +(void)webViewInit:(WKWebView * _Nonnull)webView :(NSURLRequest * _Nonnull)request;
		[Static]
		[Export ("webViewInit::")]
		void WebViewInit (WKWebView webView, NSURLRequest request);

		// +(void)webViewRemove:(WKWebView * _Nonnull)webView;
		[Static]
		[Export ("webViewRemove:")]
		void WebViewRemove (WKWebView webView);

		// +(void)viewControllerDidDisappear:(UIViewController * _Nonnull)controller;
		[Static]
		[Export ("viewControllerDidDisappear:")]
		void ViewControllerDidDisappear (UIViewController controller);
	}

	// @interface LROTouchShim
	interface LROTouchShim
	{
		// -(BOOL)canBePreventedByGestureRecognizer:(id)_ __attribute__((warn_unused_result));
		[Export ("canBePreventedByGestureRecognizer:")]
		bool CanBePreventedByGestureRecognizer (NSObject _);

		// -(BOOL)canPreventGestureRecognizer:(id)_ __attribute__((warn_unused_result));
		[Export ("canPreventGestureRecognizer:")]
		bool CanPreventGestureRecognizer (NSObject _);

		// -(void)ignoreTouch:(UITouch * _Nonnull)_ forEvent:(UIEvent * _Nonnull)_;
		[Export ("ignoreTouch:forEvent:")]
		void IgnoreTouch (UITouch _, UIEvent _);

		// -(void)ignorePress:(UIPress * _Nonnull)_ forEvent:(UIPressesEvent * _Nonnull)_;
		[Export ("ignorePress:forEvent:")]
		void IgnorePress (UIPress _, UIPressesEvent _);

		// -(BOOL)shouldRequireFailureOfGestureRecognizer:(id)_ __attribute__((warn_unused_result));
		[Export ("shouldRequireFailureOfGestureRecognizer:")]
		bool ShouldRequireFailureOfGestureRecognizer (NSObject _);

		// -(BOOL)shouldBeRequiredToFailByGestureRecognizer:(id)_ __attribute__((warn_unused_result));
		[Export ("shouldBeRequiredToFailByGestureRecognizer:")]
		bool ShouldBeRequiredToFailByGestureRecognizer (NSObject _);

		// -(void)touchesBegan:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nonnull)_;
		[Export ("touchesBegan:withEvent:")]
		void TouchesBegan (NSSet touches, UIEvent _);

		// -(void)touchesCancelled:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event;
		[Export ("touchesCancelled:withEvent:")]
		void TouchesCancelled (NSSet touches, UIEvent @event);

		// -(void)touchesEnded:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nonnull)_;
		[Export ("touchesEnded:withEvent:")]
		void TouchesEnded (NSSet touches, UIEvent _);

		// -(void)touchesMoved:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nonnull)_;
		[Export ("touchesMoved:withEvent:")]
		void TouchesMoved (NSSet touches, UIEvent _);

		// -(BOOL)gestureRecognizer:(id)_ shouldRecognizeSimultaneouslyWithGestureRecognizer:(id)_ __attribute__((warn_unused_result));
		[Export ("gestureRecognizer:shouldRecognizeSimultaneouslyWithGestureRecognizer:")]
		bool GestureRecognizer (NSObject _, NSObject _);
	}

	// @interface WebViewObserver : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC9LogRocket15WebViewObserver")]
	[DisableDefaultCtor]
	interface WebViewObserver
	{
		// -(void)userContentController:(WKUserContentController * _Nonnull)_ didReceiveScriptMessage:(WKScriptMessage * _Nonnull)message;
		[Export ("userContentController:didReceiveScriptMessage:")]
		void UserContentController (WKUserContentController _, WKScriptMessage message);
	}
}
