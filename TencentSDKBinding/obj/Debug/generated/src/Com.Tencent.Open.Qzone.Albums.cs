using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Open.Qzone {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.qzone']/class[@name='Albums']"
	[global::Android.Runtime.Register ("com/tencent/open/qzone/Albums", DoNotGenerateAcw=true)]
	public partial class Albums : global::Com.Tencent.Connect.Common.BaseApi {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.qzone']/class[@name='Albums.AlbumSecurity']"
		[global::Android.Runtime.Register ("com/tencent/open/qzone/Albums$AlbumSecurity", DoNotGenerateAcw=true)]
		public sealed partial class AlbumSecurity : global::Java.Lang.Enum {


			static IntPtr friendsOnly_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.qzone']/class[@name='Albums.AlbumSecurity']/field[@name='friendsOnly']"
			[Register ("friendsOnly")]
			public static global::Com.Tencent.Open.Qzone.Albums.AlbumSecurity FriendsOnly {
				get {
					if (friendsOnly_jfieldId == IntPtr.Zero)
						friendsOnly_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "friendsOnly", "Lcom/tencent/open/qzone/Albums$AlbumSecurity;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, friendsOnly_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Qzone.Albums.AlbumSecurity> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr needQuestion_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.qzone']/class[@name='Albums.AlbumSecurity']/field[@name='needQuestion']"
			[Register ("needQuestion")]
			public static global::Com.Tencent.Open.Qzone.Albums.AlbumSecurity NeedQuestion {
				get {
					if (needQuestion_jfieldId == IntPtr.Zero)
						needQuestion_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "needQuestion", "Lcom/tencent/open/qzone/Albums$AlbumSecurity;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, needQuestion_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Qzone.Albums.AlbumSecurity> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr privateOnly_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.qzone']/class[@name='Albums.AlbumSecurity']/field[@name='privateOnly']"
			[Register ("privateOnly")]
			public static global::Com.Tencent.Open.Qzone.Albums.AlbumSecurity PrivateOnly {
				get {
					if (privateOnly_jfieldId == IntPtr.Zero)
						privateOnly_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "privateOnly", "Lcom/tencent/open/qzone/Albums$AlbumSecurity;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, privateOnly_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Qzone.Albums.AlbumSecurity> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr publicToAll_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.qzone']/class[@name='Albums.AlbumSecurity']/field[@name='publicToAll']"
			[Register ("publicToAll")]
			public static global::Com.Tencent.Open.Qzone.Albums.AlbumSecurity PublicToAll {
				get {
					if (publicToAll_jfieldId == IntPtr.Zero)
						publicToAll_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "publicToAll", "Lcom/tencent/open/qzone/Albums$AlbumSecurity;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, publicToAll_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Qzone.Albums.AlbumSecurity> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/open/qzone/Albums$AlbumSecurity", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AlbumSecurity); }
			}

			internal AlbumSecurity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getSecurity;
			public unsafe string Security {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.qzone']/class[@name='Albums.AlbumSecurity']/method[@name='getSecurity' and count(parameter)=0]"
				[Register ("getSecurity", "()Ljava/lang/String;", "GetGetSecurityHandler")]
				get {
					if (id_getSecurity == IntPtr.Zero)
						id_getSecurity = JNIEnv.GetMethodID (class_ref, "getSecurity", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSecurity), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/open/qzone/Albums", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Albums); }
		}

		protected Albums (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQAuth_Lcom_tencent_connect_auth_QQToken_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open.qzone']/class[@name='Albums']/constructor[@name='Albums' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.tencent.connect.auth.QQAuth'] and parameter[3][@type='com.tencent.connect.auth.QQToken']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/tencent/connect/auth/QQAuth;Lcom/tencent/connect/auth/QQToken;)V", "")]
		public unsafe Albums (global::Android.Content.Context p0, global::Com.Tencent.Connect.Auth.QQAuth p1, global::Com.Tencent.Connect.Auth.QQToken p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (Albums)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/tencent/connect/auth/QQAuth;Lcom/tencent/connect/auth/QQToken;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/tencent/connect/auth/QQAuth;Lcom/tencent/connect/auth/QQToken;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQAuth_Lcom_tencent_connect_auth_QQToken_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQAuth_Lcom_tencent_connect_auth_QQToken_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/tencent/connect/auth/QQAuth;Lcom/tencent/connect/auth/QQToken;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQAuth_Lcom_tencent_connect_auth_QQToken_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQAuth_Lcom_tencent_connect_auth_QQToken_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQToken_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open.qzone']/class[@name='Albums']/constructor[@name='Albums' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.tencent.connect.auth.QQToken']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/tencent/connect/auth/QQToken;)V", "")]
		public unsafe Albums (global::Android.Content.Context p0, global::Com.Tencent.Connect.Auth.QQToken p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (Albums)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/tencent/connect/auth/QQToken;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/tencent/connect/auth/QQToken;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQToken_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQToken_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/tencent/connect/auth/QQToken;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQToken_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQToken_, __args);
			} finally {
			}
		}

		static Delegate cb_addAlbum_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_open_qzone_Albums_AlbumSecurity_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetAddAlbum_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_open_qzone_Albums_AlbumSecurity_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_addAlbum_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_open_qzone_Albums_AlbumSecurity_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == null)
				cb_addAlbum_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_open_qzone_Albums_AlbumSecurity_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddAlbum_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_open_qzone_Albums_AlbumSecurity_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_);
			return cb_addAlbum_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_open_qzone_Albums_AlbumSecurity_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_AddAlbum_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_open_qzone_Albums_AlbumSecurity_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Com.Tencent.Open.Qzone.Albums __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Qzone.Albums> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Open.Qzone.Albums.AlbumSecurity p2 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Qzone.Albums.AlbumSecurity> (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p5 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.AddAlbum (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		static IntPtr id_addAlbum_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_open_qzone_Albums_AlbumSecurity_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.qzone']/class[@name='Albums']/method[@name='addAlbum' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.tencent.open.qzone.Albums.AlbumSecurity'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='com.tencent.tauth.IUiListener']]"
		[Register ("addAlbum", "(Ljava/lang/String;Ljava/lang/String;Lcom/tencent/open/qzone/Albums$AlbumSecurity;Ljava/lang/String;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V", "GetAddAlbum_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_open_qzone_Albums_AlbumSecurity_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void AddAlbum (string p0, string p1, global::Com.Tencent.Open.Qzone.Albums.AlbumSecurity p2, string p3, string p4, global::Com.Tencent.Tauth.IUiListener p5)
		{
			if (id_addAlbum_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_open_qzone_Albums_AlbumSecurity_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_addAlbum_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_open_qzone_Albums_AlbumSecurity_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "addAlbum", "(Ljava/lang/String;Ljava/lang/String;Lcom/tencent/open/qzone/Albums$AlbumSecurity;Ljava/lang/String;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addAlbum_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_open_qzone_Albums_AlbumSecurity_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAlbum", "(Ljava/lang/String;Ljava/lang/String;Lcom/tencent/open/qzone/Albums$AlbumSecurity;Ljava/lang/String;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_listAlbum_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetListAlbum_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_listAlbum_Lcom_tencent_tauth_IUiListener_ == null)
				cb_listAlbum_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ListAlbum_Lcom_tencent_tauth_IUiListener_);
			return cb_listAlbum_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_ListAlbum_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Open.Qzone.Albums __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Qzone.Albums> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p0 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ListAlbum (p0);
		}
#pragma warning restore 0169

		static IntPtr id_listAlbum_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.qzone']/class[@name='Albums']/method[@name='listAlbum' and count(parameter)=1 and parameter[1][@type='com.tencent.tauth.IUiListener']]"
		[Register ("listAlbum", "(Lcom/tencent/tauth/IUiListener;)V", "GetListAlbum_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void ListAlbum (global::Com.Tencent.Tauth.IUiListener p0)
		{
			if (id_listAlbum_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_listAlbum_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "listAlbum", "(Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_listAlbum_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "listAlbum", "(Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_listPhotos_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetListPhotos_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_listPhotos_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == null)
				cb_listPhotos_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ListPhotos_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_);
			return cb_listPhotos_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_ListPhotos_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Open.Qzone.Albums __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Qzone.Albums> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p1 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ListPhotos (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_listPhotos_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.qzone']/class[@name='Albums']/method[@name='listPhotos' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.tencent.tauth.IUiListener']]"
		[Register ("listPhotos", "(Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V", "GetListPhotos_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void ListPhotos (string p0, global::Com.Tencent.Tauth.IUiListener p1)
		{
			if (id_listPhotos_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_listPhotos_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "listPhotos", "(Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_listPhotos_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "listPhotos", "(Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_uploadPicture_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetUploadPicture_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_uploadPicture_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == null)
				cb_uploadPicture_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UploadPicture_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_);
			return cb_uploadPicture_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_UploadPicture_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Com.Tencent.Open.Qzone.Albums __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Qzone.Albums> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p5 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.UploadPicture (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		static IntPtr id_uploadPicture_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.qzone']/class[@name='Albums']/method[@name='uploadPicture' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='com.tencent.tauth.IUiListener']]"
		[Register ("uploadPicture", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V", "GetUploadPicture_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void UploadPicture (string p0, string p1, string p2, string p3, string p4, global::Com.Tencent.Tauth.IUiListener p5)
		{
			if (id_uploadPicture_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_uploadPicture_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "uploadPicture", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_uploadPicture_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "uploadPicture", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

	}
}
