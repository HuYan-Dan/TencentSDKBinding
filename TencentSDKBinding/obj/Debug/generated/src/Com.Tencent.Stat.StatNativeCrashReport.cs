using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Stat {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatNativeCrashReport']"
	[global::Android.Runtime.Register ("com/tencent/stat/StatNativeCrashReport", DoNotGenerateAcw=true)]
	public partial class StatNativeCrashReport : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatNativeCrashReport']/field[@name='PRE_TAG_TOMBSTONE_FNAME']"
		[Register ("PRE_TAG_TOMBSTONE_FNAME")]
		public const string PreTagTombstoneFname = (string) "tombstone_";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/stat/StatNativeCrashReport", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StatNativeCrashReport); }
		}

		protected StatNativeCrashReport (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatNativeCrashReport']/constructor[@name='StatNativeCrashReport' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StatNativeCrashReport ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (StatNativeCrashReport)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_isNativeCrashDebugEnable;
		static IntPtr id_setNativeCrashDebugEnable_Z;
		public static unsafe bool NativeCrashDebugEnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatNativeCrashReport']/method[@name='isNativeCrashDebugEnable' and count(parameter)=0]"
			[Register ("isNativeCrashDebugEnable", "()Z", "GetIsNativeCrashDebugEnableHandler")]
			get {
				if (id_isNativeCrashDebugEnable == IntPtr.Zero)
					id_isNativeCrashDebugEnable = JNIEnv.GetStaticMethodID (class_ref, "isNativeCrashDebugEnable", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNativeCrashDebugEnable);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatNativeCrashReport']/method[@name='setNativeCrashDebugEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setNativeCrashDebugEnable", "(Z)V", "GetSetNativeCrashDebugEnable_ZHandler")]
			set {
				if (id_setNativeCrashDebugEnable_Z == IntPtr.Zero)
					id_setNativeCrashDebugEnable_Z = JNIEnv.GetStaticMethodID (class_ref, "setNativeCrashDebugEnable", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setNativeCrashDebugEnable_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_isNativeCrashEnable;
		static IntPtr id_setNativeCrashEnable_Z;
		public static unsafe bool NativeCrashEnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatNativeCrashReport']/method[@name='isNativeCrashEnable' and count(parameter)=0]"
			[Register ("isNativeCrashEnable", "()Z", "GetIsNativeCrashEnableHandler")]
			get {
				if (id_isNativeCrashEnable == IntPtr.Zero)
					id_isNativeCrashEnable = JNIEnv.GetStaticMethodID (class_ref, "isNativeCrashEnable", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNativeCrashEnable);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatNativeCrashReport']/method[@name='setNativeCrashEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setNativeCrashEnable", "(Z)V", "GetSetNativeCrashEnable_ZHandler")]
			set {
				if (id_setNativeCrashEnable_Z == IntPtr.Zero)
					id_setNativeCrashEnable_Z = JNIEnv.GetStaticMethodID (class_ref, "setNativeCrashEnable", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setNativeCrashEnable_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_doNativeCrashTest;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatNativeCrashReport']/method[@name='doNativeCrashTest' and count(parameter)=0]"
		[Register ("doNativeCrashTest", "()V", "")]
		public static unsafe void DoNativeCrashTest ()
		{
			if (id_doNativeCrashTest == IntPtr.Zero)
				id_doNativeCrashTest = JNIEnv.GetStaticMethodID (class_ref, "doNativeCrashTest", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_doNativeCrashTest);
			} finally {
			}
		}

		static Delegate cb_enableNativeCrash_Z;
#pragma warning disable 0169
		static Delegate GetEnableNativeCrash_ZHandler ()
		{
			if (cb_enableNativeCrash_Z == null)
				cb_enableNativeCrash_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_EnableNativeCrash_Z);
			return cb_enableNativeCrash_Z;
		}

		static void n_EnableNativeCrash_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Tencent.Stat.StatNativeCrashReport __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatNativeCrashReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableNativeCrash (p0);
		}
#pragma warning restore 0169

		static IntPtr id_enableNativeCrash_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatNativeCrashReport']/method[@name='enableNativeCrash' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableNativeCrash", "(Z)V", "GetEnableNativeCrash_ZHandler")]
		public virtual unsafe void EnableNativeCrash (bool p0)
		{
			if (id_enableNativeCrash_Z == IntPtr.Zero)
				id_enableNativeCrash_Z = JNIEnv.GetMethodID (class_ref, "enableNativeCrash", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_enableNativeCrash_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableNativeCrash", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_enableNativeCrashDebug_Z;
#pragma warning disable 0169
		static Delegate GetEnableNativeCrashDebug_ZHandler ()
		{
			if (cb_enableNativeCrashDebug_Z == null)
				cb_enableNativeCrashDebug_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_EnableNativeCrashDebug_Z);
			return cb_enableNativeCrashDebug_Z;
		}

		static void n_EnableNativeCrashDebug_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Tencent.Stat.StatNativeCrashReport __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatNativeCrashReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableNativeCrashDebug (p0);
		}
#pragma warning restore 0169

		static IntPtr id_enableNativeCrashDebug_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatNativeCrashReport']/method[@name='enableNativeCrashDebug' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableNativeCrashDebug", "(Z)V", "GetEnableNativeCrashDebug_ZHandler")]
		public virtual unsafe void EnableNativeCrashDebug (bool p0)
		{
			if (id_enableNativeCrashDebug_Z == IntPtr.Zero)
				id_enableNativeCrashDebug_Z = JNIEnv.GetMethodID (class_ref, "enableNativeCrashDebug", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_enableNativeCrashDebug_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableNativeCrashDebug", "(Z)V"), __args);
			} finally {
			}
		}

		static IntPtr id_getTombstonesDir_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatNativeCrashReport']/method[@name='getTombstonesDir' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getTombstonesDir", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetTombstonesDir (global::Android.Content.Context p0)
		{
			if (id_getTombstonesDir_Landroid_content_Context_ == IntPtr.Zero)
				id_getTombstonesDir_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getTombstonesDir", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTombstonesDir_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_initJNICrash_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInitJNICrash_Ljava_lang_String_Handler ()
		{
			if (cb_initJNICrash_Ljava_lang_String_ == null)
				cb_initJNICrash_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_InitJNICrash_Ljava_lang_String_);
			return cb_initJNICrash_Ljava_lang_String_;
		}

		static bool n_InitJNICrash_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Stat.StatNativeCrashReport __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatNativeCrashReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.InitJNICrash (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_initJNICrash_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatNativeCrashReport']/method[@name='initJNICrash' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("initJNICrash", "(Ljava/lang/String;)Z", "GetInitJNICrash_Ljava_lang_String_Handler")]
		public virtual unsafe bool InitJNICrash (string p0)
		{
			if (id_initJNICrash_Ljava_lang_String_ == IntPtr.Zero)
				id_initJNICrash_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "initJNICrash", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_initJNICrash_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initJNICrash", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_initNativeCrash_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatNativeCrashReport']/method[@name='initNativeCrash' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("initNativeCrash", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void InitNativeCrash (global::Android.Content.Context p0, string p1)
		{
			if (id_initNativeCrash_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_initNativeCrash_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "initNativeCrash", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_initNativeCrash_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_makeJniCrash;
#pragma warning disable 0169
		static Delegate GetMakeJniCrashHandler ()
		{
			if (cb_makeJniCrash == null)
				cb_makeJniCrash = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_MakeJniCrash);
			return cb_makeJniCrash;
		}

		static IntPtr n_MakeJniCrash (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Stat.StatNativeCrashReport __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatNativeCrashReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MakeJniCrash ());
		}
#pragma warning restore 0169

		static IntPtr id_makeJniCrash;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatNativeCrashReport']/method[@name='makeJniCrash' and count(parameter)=0]"
		[Register ("makeJniCrash", "()Ljava/lang/String;", "GetMakeJniCrashHandler")]
		public virtual unsafe string MakeJniCrash ()
		{
			if (id_makeJniCrash == IntPtr.Zero)
				id_makeJniCrash = JNIEnv.GetMethodID (class_ref, "makeJniCrash", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_makeJniCrash), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "makeJniCrash", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_onNativeCrashHappened;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatNativeCrashReport']/method[@name='onNativeCrashHappened' and count(parameter)=0]"
		[Register ("onNativeCrashHappened", "()Ljava/lang/String;", "")]
		public static unsafe string OnNativeCrashHappened ()
		{
			if (id_onNativeCrashHappened == IntPtr.Zero)
				id_onNativeCrashHappened = JNIEnv.GetStaticMethodID (class_ref, "onNativeCrashHappened", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_onNativeCrashHappened), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_stringFromJNI;
#pragma warning disable 0169
		static Delegate GetStringFromJNIHandler ()
		{
			if (cb_stringFromJNI == null)
				cb_stringFromJNI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_StringFromJNI);
			return cb_stringFromJNI;
		}

		static IntPtr n_StringFromJNI (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Stat.StatNativeCrashReport __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatNativeCrashReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StringFromJNI ());
		}
#pragma warning restore 0169

		static IntPtr id_stringFromJNI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatNativeCrashReport']/method[@name='stringFromJNI' and count(parameter)=0]"
		[Register ("stringFromJNI", "()Ljava/lang/String;", "GetStringFromJNIHandler")]
		public virtual unsafe string StringFromJNI ()
		{
			if (id_stringFromJNI == IntPtr.Zero)
				id_stringFromJNI = JNIEnv.GetMethodID (class_ref, "stringFromJNI", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_stringFromJNI), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stringFromJNI", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
