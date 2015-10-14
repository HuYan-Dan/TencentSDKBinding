using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Stat {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.stat']/class[@name='DeviceInfo']"
	[global::Android.Runtime.Register ("com/tencent/stat/DeviceInfo", DoNotGenerateAcw=true)]
	public partial class DeviceInfo : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.stat']/class[@name='DeviceInfo']/field[@name='NEW_USER']"
		[Register ("NEW_USER")]
		public const int NewUser = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.stat']/class[@name='DeviceInfo']/field[@name='OLD_USER']"
		[Register ("OLD_USER")]
		public const int OldUser = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.stat']/class[@name='DeviceInfo']/field[@name='TAG_ANDROID_ID']"
		[Register ("TAG_ANDROID_ID")]
		public const string TagAndroidId = (string) "aid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.stat']/class[@name='DeviceInfo']/field[@name='TAG_FLAG']"
		[Register ("TAG_FLAG")]
		public const string TagFlag = (string) "__MTA_DEVICE_INFO__";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.stat']/class[@name='DeviceInfo']/field[@name='TAG_IMEI']"
		[Register ("TAG_IMEI")]
		public const string TagImei = (string) "ui";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.stat']/class[@name='DeviceInfo']/field[@name='TAG_MAC']"
		[Register ("TAG_MAC")]
		public const string TagMac = (string) "mc";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.stat']/class[@name='DeviceInfo']/field[@name='TAG_MID']"
		[Register ("TAG_MID")]
		public const string TagMid = (string) "mid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.stat']/class[@name='DeviceInfo']/field[@name='TAG_TIMESTAMPS']"
		[Register ("TAG_TIMESTAMPS")]
		public const string TagTimestamps = (string) "ts";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.stat']/class[@name='DeviceInfo']/field[@name='TAG_VERSION']"
		[Register ("TAG_VERSION")]
		public const string TagVersion = (string) "ver";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.stat']/class[@name='DeviceInfo']/field[@name='UPGRADE_USER']"
		[Register ("UPGRADE_USER")]
		public const int UpgradeUser = (int) 2;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/stat/DeviceInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeviceInfo); }
		}

		protected DeviceInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getImei;
#pragma warning disable 0169
		static Delegate GetGetImeiHandler ()
		{
			if (cb_getImei == null)
				cb_getImei = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImei);
			return cb_getImei;
		}

		static IntPtr n_GetImei (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Stat.DeviceInfo __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.DeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Imei);
		}
#pragma warning restore 0169

		static IntPtr id_getImei;
		public virtual unsafe string Imei {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='DeviceInfo']/method[@name='getImei' and count(parameter)=0]"
			[Register ("getImei", "()Ljava/lang/String;", "GetGetImeiHandler")]
			get {
				if (id_getImei == IntPtr.Zero)
					id_getImei = JNIEnv.GetMethodID (class_ref, "getImei", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getImei), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImei", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMac;
#pragma warning disable 0169
		static Delegate GetGetMacHandler ()
		{
			if (cb_getMac == null)
				cb_getMac = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMac);
			return cb_getMac;
		}

		static IntPtr n_GetMac (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Stat.DeviceInfo __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.DeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Mac);
		}
#pragma warning restore 0169

		static IntPtr id_getMac;
		public virtual unsafe string Mac {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='DeviceInfo']/method[@name='getMac' and count(parameter)=0]"
			[Register ("getMac", "()Ljava/lang/String;", "GetGetMacHandler")]
			get {
				if (id_getMac == IntPtr.Zero)
					id_getMac = JNIEnv.GetMethodID (class_ref, "getMac", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMac), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMac", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMid;
#pragma warning disable 0169
		static Delegate GetGetMidHandler ()
		{
			if (cb_getMid == null)
				cb_getMid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMid);
			return cb_getMid;
		}

		static IntPtr n_GetMid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Stat.DeviceInfo __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.DeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Mid);
		}
#pragma warning restore 0169

		static IntPtr id_getMid;
		public virtual unsafe string Mid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='DeviceInfo']/method[@name='getMid' and count(parameter)=0]"
			[Register ("getMid", "()Ljava/lang/String;", "GetGetMidHandler")]
			get {
				if (id_getMid == IntPtr.Zero)
					id_getMid = JNIEnv.GetMethodID (class_ref, "getMid", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMid), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMid", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUserType;
#pragma warning disable 0169
		static Delegate GetGetUserTypeHandler ()
		{
			if (cb_getUserType == null)
				cb_getUserType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUserType);
			return cb_getUserType;
		}

		static int n_GetUserType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Stat.DeviceInfo __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.DeviceInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UserType;
		}
#pragma warning restore 0169

		static IntPtr id_getUserType;
		public virtual unsafe int UserType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='DeviceInfo']/method[@name='getUserType' and count(parameter)=0]"
			[Register ("getUserType", "()I", "GetGetUserTypeHandler")]
			get {
				if (id_getUserType == IntPtr.Zero)
					id_getUserType = JNIEnv.GetMethodID (class_ref, "getUserType", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getUserType);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserType", "()I"));
				} finally {
				}
			}
		}

	}
}
