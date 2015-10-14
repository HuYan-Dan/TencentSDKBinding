using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Open.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Global']"
	[global::Android.Runtime.Register ("com/tencent/open/utils/Global", DoNotGenerateAcw=true)]
	public sealed partial class Global : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/open/utils/Global", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Global); }
		}

		internal Global (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Global']/constructor[@name='Global' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Global ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Global)) {
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

		static IntPtr id_getContext;
		static IntPtr id_setContext_Landroid_content_Context_;
		public static unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Global']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get {
				if (id_getContext == IntPtr.Zero)
					id_getContext = JNIEnv.GetStaticMethodID (class_ref, "getContext", "()Landroid/content/Context;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getContext), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Global']/method[@name='setContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register ("setContext", "(Landroid/content/Context;)V", "GetSetContext_Landroid_content_Context_Handler")]
			set {
				if (id_setContext_Landroid_content_Context_ == IntPtr.Zero)
					id_setContext_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "setContext", "(Landroid/content/Context;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setContext_Landroid_content_Context_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getFilesDir;
		public static unsafe global::Java.IO.File FilesDir {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Global']/method[@name='getFilesDir' and count(parameter)=0]"
			[Register ("getFilesDir", "()Ljava/io/File;", "GetGetFilesDirHandler")]
			get {
				if (id_getFilesDir == IntPtr.Zero)
					id_getFilesDir = JNIEnv.GetStaticMethodID (class_ref, "getFilesDir", "()Ljava/io/File;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFilesDir), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getPackageName;
		public static unsafe string PackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Global']/method[@name='getPackageName' and count(parameter)=0]"
			[Register ("getPackageName", "()Ljava/lang/String;", "GetGetPackageNameHandler")]
			get {
				if (id_getPackageName == IntPtr.Zero)
					id_getPackageName = JNIEnv.GetStaticMethodID (class_ref, "getPackageName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPackageName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getVersionCode;
		public static unsafe int VersionCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Global']/method[@name='getVersionCode' and count(parameter)=0]"
			[Register ("getVersionCode", "()I", "GetGetVersionCodeHandler")]
			get {
				if (id_getVersionCode == IntPtr.Zero)
					id_getVersionCode = JNIEnv.GetStaticMethodID (class_ref, "getVersionCode", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getVersionCode);
				} finally {
				}
			}
		}

		static IntPtr id_getSharedPreferences_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Global']/method[@name='getSharedPreferences' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getSharedPreferences", "(Ljava/lang/String;I)Landroid/content/SharedPreferences;", "")]
		public static unsafe global::Android.Content.ISharedPreferences GetSharedPreferences (string p0, int p1)
		{
			if (id_getSharedPreferences_Ljava_lang_String_I == IntPtr.Zero)
				id_getSharedPreferences_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "getSharedPreferences", "(Ljava/lang/String;I)Landroid/content/SharedPreferences;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Android.Content.ISharedPreferences __ret = global::Java.Lang.Object.GetObject<global::Android.Content.ISharedPreferences> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSharedPreferences_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_saveVersionCode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Global']/method[@name='saveVersionCode' and count(parameter)=0]"
		[Register ("saveVersionCode", "()V", "")]
		public static unsafe void SaveVersionCode ()
		{
			if (id_saveVersionCode == IntPtr.Zero)
				id_saveVersionCode = JNIEnv.GetStaticMethodID (class_ref, "saveVersionCode", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_saveVersionCode);
			} finally {
			}
		}

	}
}
