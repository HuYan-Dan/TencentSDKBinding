using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Stat {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatGameUser']"
	[global::Android.Runtime.Register ("com/tencent/stat/StatGameUser", DoNotGenerateAcw=true)]
	public partial class StatGameUser : global::Java.Lang.Object, global::Java.Lang.ICloneable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/stat/StatGameUser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StatGameUser); }
		}

		protected StatGameUser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatGameUser']/constructor[@name='StatGameUser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StatGameUser ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (StatGameUser)) {
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

		static Delegate cb_getAccount;
#pragma warning disable 0169
		static Delegate GetGetAccountHandler ()
		{
			if (cb_getAccount == null)
				cb_getAccount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccount);
			return cb_getAccount;
		}

		static IntPtr n_GetAccount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Stat.StatGameUser __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatGameUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Account);
		}
#pragma warning restore 0169

		static Delegate cb_setAccount_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAccount_Ljava_lang_String_Handler ()
		{
			if (cb_setAccount_Ljava_lang_String_ == null)
				cb_setAccount_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAccount_Ljava_lang_String_);
			return cb_setAccount_Ljava_lang_String_;
		}

		static void n_SetAccount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Stat.StatGameUser __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatGameUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Account = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAccount;
		static IntPtr id_setAccount_Ljava_lang_String_;
		public virtual unsafe string Account {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatGameUser']/method[@name='getAccount' and count(parameter)=0]"
			[Register ("getAccount", "()Ljava/lang/String;", "GetGetAccountHandler")]
			get {
				if (id_getAccount == IntPtr.Zero)
					id_getAccount = JNIEnv.GetMethodID (class_ref, "getAccount", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAccount), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccount", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatGameUser']/method[@name='setAccount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAccount", "(Ljava/lang/String;)V", "GetSetAccount_Ljava_lang_String_Handler")]
			set {
				if (id_setAccount_Ljava_lang_String_ == IntPtr.Zero)
					id_setAccount_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAccount", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAccount_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAccount", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getLevel;
#pragma warning disable 0169
		static Delegate GetGetLevelHandler ()
		{
			if (cb_getLevel == null)
				cb_getLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLevel);
			return cb_getLevel;
		}

		static IntPtr n_GetLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Stat.StatGameUser __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatGameUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Level);
		}
#pragma warning restore 0169

		static Delegate cb_setLevel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLevel_Ljava_lang_String_Handler ()
		{
			if (cb_setLevel_Ljava_lang_String_ == null)
				cb_setLevel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLevel_Ljava_lang_String_);
			return cb_setLevel_Ljava_lang_String_;
		}

		static void n_SetLevel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Stat.StatGameUser __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatGameUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Level = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLevel;
		static IntPtr id_setLevel_Ljava_lang_String_;
		public virtual unsafe string Level {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatGameUser']/method[@name='getLevel' and count(parameter)=0]"
			[Register ("getLevel", "()Ljava/lang/String;", "GetGetLevelHandler")]
			get {
				if (id_getLevel == IntPtr.Zero)
					id_getLevel = JNIEnv.GetMethodID (class_ref, "getLevel", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLevel), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLevel", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatGameUser']/method[@name='setLevel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLevel", "(Ljava/lang/String;)V", "GetSetLevel_Ljava_lang_String_Handler")]
			set {
				if (id_setLevel_Ljava_lang_String_ == IntPtr.Zero)
					id_setLevel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLevel", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setLevel_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLevel", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getWorldName;
#pragma warning disable 0169
		static Delegate GetGetWorldNameHandler ()
		{
			if (cb_getWorldName == null)
				cb_getWorldName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWorldName);
			return cb_getWorldName;
		}

		static IntPtr n_GetWorldName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Stat.StatGameUser __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatGameUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.WorldName);
		}
#pragma warning restore 0169

		static Delegate cb_setWorldName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetWorldName_Ljava_lang_String_Handler ()
		{
			if (cb_setWorldName_Ljava_lang_String_ == null)
				cb_setWorldName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWorldName_Ljava_lang_String_);
			return cb_setWorldName_Ljava_lang_String_;
		}

		static void n_SetWorldName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Stat.StatGameUser __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatGameUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WorldName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWorldName;
		static IntPtr id_setWorldName_Ljava_lang_String_;
		public virtual unsafe string WorldName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatGameUser']/method[@name='getWorldName' and count(parameter)=0]"
			[Register ("getWorldName", "()Ljava/lang/String;", "GetGetWorldNameHandler")]
			get {
				if (id_getWorldName == IntPtr.Zero)
					id_getWorldName = JNIEnv.GetMethodID (class_ref, "getWorldName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getWorldName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWorldName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatGameUser']/method[@name='setWorldName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setWorldName", "(Ljava/lang/String;)V", "GetSetWorldName_Ljava_lang_String_Handler")]
			set {
				if (id_setWorldName_Ljava_lang_String_ == IntPtr.Zero)
					id_setWorldName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setWorldName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setWorldName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWorldName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_clone;
#pragma warning disable 0169
		static Delegate GetCloneHandler ()
		{
			if (cb_clone == null)
				cb_clone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Clone);
			return cb_clone;
		}

		static IntPtr n_Clone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Stat.StatGameUser __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatGameUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatGameUser']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lcom/tencent/stat/StatGameUser;", "GetCloneHandler")]
		public virtual unsafe global::Com.Tencent.Stat.StatGameUser Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lcom/tencent/stat/StatGameUser;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatGameUser> (JNIEnv.CallObjectMethod  (Handle, id_clone), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatGameUser> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clone", "()Lcom/tencent/stat/StatGameUser;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
