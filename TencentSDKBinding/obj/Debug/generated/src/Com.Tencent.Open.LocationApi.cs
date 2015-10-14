using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Open {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open']/class[@name='LocationApi']"
	[global::Android.Runtime.Register ("com/tencent/open/LocationApi", DoNotGenerateAcw=true)]
	public partial class LocationApi : global::Com.Tencent.Connect.Common.BaseApi, global::Com.Tencent.Open.C.IA {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/open/LocationApi", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LocationApi); }
		}

		protected LocationApi (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_tencent_connect_auth_QQToken_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open']/class[@name='LocationApi']/constructor[@name='LocationApi' and count(parameter)=1 and parameter[1][@type='com.tencent.connect.auth.QQToken']]"
		[Register (".ctor", "(Lcom/tencent/connect/auth/QQToken;)V", "")]
		public unsafe LocationApi (global::Com.Tencent.Connect.Auth.QQToken p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (LocationApi)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/tencent/connect/auth/QQToken;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/tencent/connect/auth/QQToken;)V", __args);
					return;
				}

				if (id_ctor_Lcom_tencent_connect_auth_QQToken_ == IntPtr.Zero)
					id_ctor_Lcom_tencent_connect_auth_QQToken_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/tencent/connect/auth/QQToken;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_tencent_connect_auth_QQToken_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_tencent_connect_auth_QQToken_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_tencent_connect_auth_QQAuth_Lcom_tencent_connect_auth_QQToken_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open']/class[@name='LocationApi']/constructor[@name='LocationApi' and count(parameter)=2 and parameter[1][@type='com.tencent.connect.auth.QQAuth'] and parameter[2][@type='com.tencent.connect.auth.QQToken']]"
		[Register (".ctor", "(Lcom/tencent/connect/auth/QQAuth;Lcom/tencent/connect/auth/QQToken;)V", "")]
		public unsafe LocationApi (global::Com.Tencent.Connect.Auth.QQAuth p0, global::Com.Tencent.Connect.Auth.QQToken p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (LocationApi)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/tencent/connect/auth/QQAuth;Lcom/tencent/connect/auth/QQToken;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/tencent/connect/auth/QQAuth;Lcom/tencent/connect/auth/QQToken;)V", __args);
					return;
				}

				if (id_ctor_Lcom_tencent_connect_auth_QQAuth_Lcom_tencent_connect_auth_QQToken_ == IntPtr.Zero)
					id_ctor_Lcom_tencent_connect_auth_QQAuth_Lcom_tencent_connect_auth_QQToken_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/tencent/connect/auth/QQAuth;Lcom/tencent/connect/auth/QQToken;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_tencent_connect_auth_QQAuth_Lcom_tencent_connect_auth_QQToken_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_tencent_connect_auth_QQAuth_Lcom_tencent_connect_auth_QQToken_, __args);
			} finally {
			}
		}

		static Delegate cb_deleteLocation_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetDeleteLocation_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_deleteLocation_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == null)
				cb_deleteLocation_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DeleteLocation_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_);
			return cb_deleteLocation_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_DeleteLocation_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Open.LocationApi __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.LocationApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.DeleteLocation (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_deleteLocation_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='LocationApi']/method[@name='deleteLocation' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("deleteLocation", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V", "GetDeleteLocation_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void DeleteLocation (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_deleteLocation_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_deleteLocation_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "deleteLocation", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_deleteLocation_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteLocation", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onLocationUpdate_Landroid_location_Location_;
#pragma warning disable 0169
		static Delegate GetOnLocationUpdate_Landroid_location_Location_Handler ()
		{
			if (cb_onLocationUpdate_Landroid_location_Location_ == null)
				cb_onLocationUpdate_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocationUpdate_Landroid_location_Location_);
			return cb_onLocationUpdate_Landroid_location_Location_;
		}

		static void n_OnLocationUpdate_Landroid_location_Location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Open.LocationApi __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.LocationApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location p0 = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocationUpdate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onLocationUpdate_Landroid_location_Location_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='LocationApi']/method[@name='onLocationUpdate' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
		[Register ("onLocationUpdate", "(Landroid/location/Location;)V", "GetOnLocationUpdate_Landroid_location_Location_Handler")]
		public virtual unsafe void OnLocationUpdate (global::Android.Locations.Location p0)
		{
			if (id_onLocationUpdate_Landroid_location_Location_ == IntPtr.Zero)
				id_onLocationUpdate_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "onLocationUpdate", "(Landroid/location/Location;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onLocationUpdate_Landroid_location_Location_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLocationUpdate", "(Landroid/location/Location;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_searchNearby_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetSearchNearby_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_searchNearby_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == null)
				cb_searchNearby_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SearchNearby_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_);
			return cb_searchNearby_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_SearchNearby_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Open.LocationApi __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.LocationApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SearchNearby (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_searchNearby_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='LocationApi']/method[@name='searchNearby' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("searchNearby", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V", "GetSearchNearby_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void SearchNearby (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_searchNearby_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_searchNearby_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "searchNearby", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_searchNearby_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "searchNearby", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

	}
}
