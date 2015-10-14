using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Stat {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatReportStrategy']"
	[global::Android.Runtime.Register ("com/tencent/stat/StatReportStrategy", DoNotGenerateAcw=true)]
	public sealed partial class StatReportStrategy : global::Java.Lang.Enum {


		static IntPtr APP_LAUNCH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatReportStrategy']/field[@name='APP_LAUNCH']"
		[Register ("APP_LAUNCH")]
		public static global::Com.Tencent.Stat.StatReportStrategy AppLaunch {
			get {
				if (APP_LAUNCH_jfieldId == IntPtr.Zero)
					APP_LAUNCH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_LAUNCH", "Lcom/tencent/stat/StatReportStrategy;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APP_LAUNCH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatReportStrategy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BATCH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatReportStrategy']/field[@name='BATCH']"
		[Register ("BATCH")]
		public static global::Com.Tencent.Stat.StatReportStrategy Batch {
			get {
				if (BATCH_jfieldId == IntPtr.Zero)
					BATCH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BATCH", "Lcom/tencent/stat/StatReportStrategy;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BATCH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatReportStrategy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DEVELOPER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatReportStrategy']/field[@name='DEVELOPER']"
		[Register ("DEVELOPER")]
		public static global::Com.Tencent.Stat.StatReportStrategy Developer {
			get {
				if (DEVELOPER_jfieldId == IntPtr.Zero)
					DEVELOPER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVELOPER", "Lcom/tencent/stat/StatReportStrategy;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEVELOPER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatReportStrategy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INSTANT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatReportStrategy']/field[@name='INSTANT']"
		[Register ("INSTANT")]
		public static global::Com.Tencent.Stat.StatReportStrategy Instant {
			get {
				if (INSTANT_jfieldId == IntPtr.Zero)
					INSTANT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTANT", "Lcom/tencent/stat/StatReportStrategy;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INSTANT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatReportStrategy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ONLY_WIFI_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatReportStrategy']/field[@name='ONLY_WIFI']"
		[Register ("ONLY_WIFI")]
		public static global::Com.Tencent.Stat.StatReportStrategy OnlyWifi {
			get {
				if (ONLY_WIFI_jfieldId == IntPtr.Zero)
					ONLY_WIFI_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ONLY_WIFI", "Lcom/tencent/stat/StatReportStrategy;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ONLY_WIFI_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatReportStrategy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ONLY_WIFI_NO_CACHE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatReportStrategy']/field[@name='ONLY_WIFI_NO_CACHE']"
		[Register ("ONLY_WIFI_NO_CACHE")]
		public static global::Com.Tencent.Stat.StatReportStrategy OnlyWifiNoCache {
			get {
				if (ONLY_WIFI_NO_CACHE_jfieldId == IntPtr.Zero)
					ONLY_WIFI_NO_CACHE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ONLY_WIFI_NO_CACHE", "Lcom/tencent/stat/StatReportStrategy;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ONLY_WIFI_NO_CACHE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatReportStrategy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PERIOD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatReportStrategy']/field[@name='PERIOD']"
		[Register ("PERIOD")]
		public static global::Com.Tencent.Stat.StatReportStrategy Period {
			get {
				if (PERIOD_jfieldId == IntPtr.Zero)
					PERIOD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PERIOD", "Lcom/tencent/stat/StatReportStrategy;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PERIOD_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatReportStrategy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/stat/StatReportStrategy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StatReportStrategy); }
		}

		internal StatReportStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatReportStrategy']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()I", "")]
		public unsafe int A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()I");
			try {
				return JNIEnv.CallIntMethod  (Handle, id_a);
			} finally {
			}
		}

		static IntPtr id_getStatReportStrategy_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatReportStrategy']/method[@name='getStatReportStrategy' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getStatReportStrategy", "(I)Lcom/tencent/stat/StatReportStrategy;", "")]
		public static unsafe global::Com.Tencent.Stat.StatReportStrategy GetStatReportStrategy (int p0)
		{
			if (id_getStatReportStrategy_I == IntPtr.Zero)
				id_getStatReportStrategy_I = JNIEnv.GetStaticMethodID (class_ref, "getStatReportStrategy", "(I)Lcom/tencent/stat/StatReportStrategy;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatReportStrategy> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStatReportStrategy_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatReportStrategy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/tencent/stat/StatReportStrategy;", "")]
		public static unsafe global::Com.Tencent.Stat.StatReportStrategy ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/tencent/stat/StatReportStrategy;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Tencent.Stat.StatReportStrategy __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatReportStrategy> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatReportStrategy']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/tencent/stat/StatReportStrategy;", "")]
		public static unsafe global::Com.Tencent.Stat.StatReportStrategy[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/tencent/stat/StatReportStrategy;");
			try {
				return (global::Com.Tencent.Stat.StatReportStrategy[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Tencent.Stat.StatReportStrategy));
			} finally {
			}
		}

	}
}
