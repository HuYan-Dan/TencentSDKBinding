using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Stat {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatService']"
	[global::Android.Runtime.Register ("com/tencent/stat/StatService", DoNotGenerateAcw=true)]
	public partial class StatService : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/stat/StatService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StatService); }
		}

		protected StatService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatService']/constructor[@name='StatService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StatService ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (StatService)) {
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

		static IntPtr id_commitEvents_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatService']/method[@name='commitEvents' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("commitEvents", "(Landroid/content/Context;I)V", "")]
		public static unsafe void CommitEvents (global::Android.Content.Context p0, int p1)
		{
			if (id_commitEvents_Landroid_content_Context_I == IntPtr.Zero)
				id_commitEvents_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "commitEvents", "(Landroid/content/Context;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_commitEvents_Landroid_content_Context_I, __args);
			} finally {
			}
		}

		static IntPtr id_onPause_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatService']/method[@name='onPause' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onPause", "(Landroid/content/Context;)V", "")]
		public static unsafe void OnPause (global::Android.Content.Context p0)
		{
			if (id_onPause_Landroid_content_Context_ == IntPtr.Zero)
				id_onPause_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "onPause", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onPause_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_onResume_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatService']/method[@name='onResume' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onResume", "(Landroid/content/Context;)V", "")]
		public static unsafe void OnResume (global::Android.Content.Context p0)
		{
			if (id_onResume_Landroid_content_Context_ == IntPtr.Zero)
				id_onResume_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "onResume", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onResume_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_reportAppMonitorStat_Landroid_content_Context_Lcom_tencent_stat_StatAppMonitor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatService']/method[@name='reportAppMonitorStat' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.tencent.stat.StatAppMonitor']]"
		[Register ("reportAppMonitorStat", "(Landroid/content/Context;Lcom/tencent/stat/StatAppMonitor;)V", "")]
		public static unsafe void ReportAppMonitorStat (global::Android.Content.Context p0, global::Com.Tencent.Stat.StatAppMonitor p1)
		{
			if (id_reportAppMonitorStat_Landroid_content_Context_Lcom_tencent_stat_StatAppMonitor_ == IntPtr.Zero)
				id_reportAppMonitorStat_Landroid_content_Context_Lcom_tencent_stat_StatAppMonitor_ = JNIEnv.GetStaticMethodID (class_ref, "reportAppMonitorStat", "(Landroid/content/Context;Lcom/tencent/stat/StatAppMonitor;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reportAppMonitorStat_Landroid_content_Context_Lcom_tencent_stat_StatAppMonitor_, __args);
			} finally {
			}
		}

		static IntPtr id_reportError_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatService']/method[@name='reportError' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("reportError", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void ReportError (global::Android.Content.Context p0, string p1)
		{
			if (id_reportError_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_reportError_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "reportError", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reportError_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_reportException_Landroid_content_Context_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatService']/method[@name='reportException' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("reportException", "(Landroid/content/Context;Ljava/lang/Throwable;)V", "")]
		public static unsafe void ReportException (global::Android.Content.Context p0, global::Java.Lang.Throwable p1)
		{
			if (id_reportException_Landroid_content_Context_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_reportException_Landroid_content_Context_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "reportException", "(Landroid/content/Context;Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reportException_Landroid_content_Context_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_reportGameUser_Landroid_content_Context_Lcom_tencent_stat_StatGameUser_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatService']/method[@name='reportGameUser' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.tencent.stat.StatGameUser']]"
		[Register ("reportGameUser", "(Landroid/content/Context;Lcom/tencent/stat/StatGameUser;)V", "")]
		public static unsafe void ReportGameUser (global::Android.Content.Context p0, global::Com.Tencent.Stat.StatGameUser p1)
		{
			if (id_reportGameUser_Landroid_content_Context_Lcom_tencent_stat_StatGameUser_ == IntPtr.Zero)
				id_reportGameUser_Landroid_content_Context_Lcom_tencent_stat_StatGameUser_ = JNIEnv.GetStaticMethodID (class_ref, "reportGameUser", "(Landroid/content/Context;Lcom/tencent/stat/StatGameUser;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reportGameUser_Landroid_content_Context_Lcom_tencent_stat_StatGameUser_, __args);
			} finally {
			}
		}

		static IntPtr id_reportQQ_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatService']/method[@name='reportQQ' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("reportQQ", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void ReportQQ (global::Android.Content.Context p0, string p1)
		{
			if (id_reportQQ_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_reportQQ_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "reportQQ", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reportQQ_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setEnvAttributes_Landroid_content_Context_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatService']/method[@name='setEnvAttributes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("setEnvAttributes", "(Landroid/content/Context;Ljava/util/Map;)V", "")]
		public static unsafe void SetEnvAttributes (global::Android.Content.Context p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_setEnvAttributes_Landroid_content_Context_Ljava_util_Map_ == IntPtr.Zero)
				id_setEnvAttributes_Landroid_content_Context_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "setEnvAttributes", "(Landroid/content/Context;Ljava/util/Map;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setEnvAttributes_Landroid_content_Context_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_startNewSession_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatService']/method[@name='startNewSession' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("startNewSession", "(Landroid/content/Context;)V", "")]
		public static unsafe void StartNewSession (global::Android.Content.Context p0)
		{
			if (id_startNewSession_Landroid_content_Context_ == IntPtr.Zero)
				id_startNewSession_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "startNewSession", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_startNewSession_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_startStatService_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatService']/method[@name='startStatService' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("startStatService", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static unsafe bool StartStatService (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_startStatService_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_startStatService_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "startStatService", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_startStatService_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_stopSession;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatService']/method[@name='stopSession' and count(parameter)=0]"
		[Register ("stopSession", "()V", "")]
		public static unsafe void StopSession ()
		{
			if (id_stopSession == IntPtr.Zero)
				id_stopSession = JNIEnv.GetStaticMethodID (class_ref, "stopSession", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_stopSession);
			} finally {
			}
		}

		static IntPtr id_testSpeed_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatService']/method[@name='testSpeed' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("testSpeed", "(Landroid/content/Context;)V", "")]
		public static unsafe void TestSpeed (global::Android.Content.Context p0)
		{
			if (id_testSpeed_Landroid_content_Context_ == IntPtr.Zero)
				id_testSpeed_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "testSpeed", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_testSpeed_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_testSpeed_Landroid_content_Context_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatService']/method[@name='testSpeed' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Integer&gt;']]"
		[Register ("testSpeed", "(Landroid/content/Context;Ljava/util/Map;)V", "")]
		public static unsafe void TestSpeed (global::Android.Content.Context p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Integer> p1)
		{
			if (id_testSpeed_Landroid_content_Context_Ljava_util_Map_ == IntPtr.Zero)
				id_testSpeed_Landroid_content_Context_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "testSpeed", "(Landroid/content/Context;Ljava/util/Map;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Integer>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_testSpeed_Landroid_content_Context_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_trackBeginPage_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatService']/method[@name='trackBeginPage' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("trackBeginPage", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void TrackBeginPage (global::Android.Content.Context p0, string p1)
		{
			if (id_trackBeginPage_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_trackBeginPage_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "trackBeginPage", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_trackBeginPage_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_trackCustomBeginEvent_Landroid_content_Context_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatService']/method[@name='trackCustomBeginEvent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String...']]"
		[Register ("trackCustomBeginEvent", "(Landroid/content/Context;Ljava/lang/String;[Ljava/lang/String;)V", "")]
		public static unsafe void TrackCustomBeginEvent (global::Android.Content.Context p0, string p1, params  string[] p2)
		{
			if (id_trackCustomBeginEvent_Landroid_content_Context_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_trackCustomBeginEvent_Landroid_content_Context_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "trackCustomBeginEvent", "(Landroid/content/Context;Ljava/lang/String;[Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_trackCustomBeginEvent_Landroid_content_Context_Ljava_lang_String_arrayLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_trackCustomBeginKVEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Properties_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatService']/method[@name='trackCustomBeginKVEvent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Properties']]"
		[Register ("trackCustomBeginKVEvent", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/Properties;)V", "")]
		public static unsafe void TrackCustomBeginKVEvent (global::Android.Content.Context p0, string p1, global::Java.Util.Properties p2)
		{
			if (id_trackCustomBeginKVEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Properties_ == IntPtr.Zero)
				id_trackCustomBeginKVEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Properties_ = JNIEnv.GetStaticMethodID (class_ref, "trackCustomBeginKVEvent", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/Properties;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_trackCustomBeginKVEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Properties_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_trackCustomEndEvent_Landroid_content_Context_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatService']/method[@name='trackCustomEndEvent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String...']]"
		[Register ("trackCustomEndEvent", "(Landroid/content/Context;Ljava/lang/String;[Ljava/lang/String;)V", "")]
		public static unsafe void TrackCustomEndEvent (global::Android.Content.Context p0, string p1, params  string[] p2)
		{
			if (id_trackCustomEndEvent_Landroid_content_Context_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_trackCustomEndEvent_Landroid_content_Context_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "trackCustomEndEvent", "(Landroid/content/Context;Ljava/lang/String;[Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_trackCustomEndEvent_Landroid_content_Context_Ljava_lang_String_arrayLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_trackCustomEndKVEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Properties_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatService']/method[@name='trackCustomEndKVEvent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Properties']]"
		[Register ("trackCustomEndKVEvent", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/Properties;)V", "")]
		public static unsafe void TrackCustomEndKVEvent (global::Android.Content.Context p0, string p1, global::Java.Util.Properties p2)
		{
			if (id_trackCustomEndKVEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Properties_ == IntPtr.Zero)
				id_trackCustomEndKVEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Properties_ = JNIEnv.GetStaticMethodID (class_ref, "trackCustomEndKVEvent", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/Properties;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_trackCustomEndKVEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Properties_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_trackCustomEvent_Landroid_content_Context_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatService']/method[@name='trackCustomEvent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String...']]"
		[Register ("trackCustomEvent", "(Landroid/content/Context;Ljava/lang/String;[Ljava/lang/String;)V", "")]
		public static unsafe void TrackCustomEvent (global::Android.Content.Context p0, string p1, params  string[] p2)
		{
			if (id_trackCustomEvent_Landroid_content_Context_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_trackCustomEvent_Landroid_content_Context_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "trackCustomEvent", "(Landroid/content/Context;Ljava/lang/String;[Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_trackCustomEvent_Landroid_content_Context_Ljava_lang_String_arrayLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_trackCustomKVEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Properties_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatService']/method[@name='trackCustomKVEvent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Properties']]"
		[Register ("trackCustomKVEvent", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/Properties;)V", "")]
		public static unsafe void TrackCustomKVEvent (global::Android.Content.Context p0, string p1, global::Java.Util.Properties p2)
		{
			if (id_trackCustomKVEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Properties_ == IntPtr.Zero)
				id_trackCustomKVEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Properties_ = JNIEnv.GetStaticMethodID (class_ref, "trackCustomKVEvent", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/Properties;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_trackCustomKVEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Properties_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_trackEndPage_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatService']/method[@name='trackEndPage' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("trackEndPage", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void TrackEndPage (global::Android.Content.Context p0, string p1)
		{
			if (id_trackEndPage_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_trackEndPage_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "trackEndPage", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_trackEndPage_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
