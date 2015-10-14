using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Open {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open']/class[@name='c']"
	[global::Android.Runtime.Register ("com/tencent/open/c", DoNotGenerateAcw=true)]
	public partial class C : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.open']/interface[@name='c.a']"
		[Register ("com/tencent/open/c$a", "", "Com.Tencent.Open.C/IAInvoker")]
		public partial interface IA : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/interface[@name='c.a']/method[@name='onLocationUpdate' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
			[Register ("onLocationUpdate", "(Landroid/location/Location;)V", "GetOnLocationUpdate_Landroid_location_Location_Handler:Com.Tencent.Open.C/IAInvoker, TencentSDKBinding_v2.9.3")]
			void OnLocationUpdate (global::Android.Locations.Location p0);

		}

		[global::Android.Runtime.Register ("com/tencent/open/c$a", DoNotGenerateAcw=true)]
		internal class IAInvoker : global::Java.Lang.Object, IA {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/tencent/open/c$a");
			IntPtr class_ref;

			public static IA GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IA> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.tencent.open.c.a"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IAInvoker); }
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
				global::Com.Tencent.Open.C.IA __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.C.IA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Locations.Location p0 = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLocationUpdate (p0);
			}
#pragma warning restore 0169

			IntPtr id_onLocationUpdate_Landroid_location_Location_;
			public unsafe void OnLocationUpdate (global::Android.Locations.Location p0)
			{
				if (id_onLocationUpdate_Landroid_location_Location_ == IntPtr.Zero)
					id_onLocationUpdate_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "onLocationUpdate", "(Landroid/location/Location;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onLocationUpdate_Landroid_location_Location_, __args);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/open/c", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (C); }
		}

		protected C (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open']/class[@name='c']/constructor[@name='c' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe C ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (C)) {
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

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_A);
			return cb_a;
		}

		static bool n_A (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Open.C __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.C> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.A ();
		}
#pragma warning restore 0169

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='c']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Z", "GetAHandler")]
		public virtual unsafe bool A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_a);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "()Z"));
			} finally {
			}
		}

		static Delegate cb_a_Landroid_content_Context_Lcom_tencent_open_c_a_;
#pragma warning disable 0169
		static Delegate GetA_Landroid_content_Context_Lcom_tencent_open_c_a_Handler ()
		{
			if (cb_a_Landroid_content_Context_Lcom_tencent_open_c_a_ == null)
				cb_a_Landroid_content_Context_Lcom_tencent_open_c_a_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Landroid_content_Context_Lcom_tencent_open_c_a_);
			return cb_a_Landroid_content_Context_Lcom_tencent_open_c_a_;
		}

		static void n_A_Landroid_content_Context_Lcom_tencent_open_c_a_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Open.C __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.C> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Open.C.IA p1 = (global::Com.Tencent.Open.C.IA)global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.C.IA> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.A (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_a_Landroid_content_Context_Lcom_tencent_open_c_a_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='c']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.tencent.open.c.a']]"
		[Register ("a", "(Landroid/content/Context;Lcom/tencent/open/c$a;)V", "GetA_Landroid_content_Context_Lcom_tencent_open_c_a_Handler")]
		public virtual unsafe void A (global::Android.Content.Context p0, global::Com.Tencent.Open.C.IA p1)
		{
			if (id_a_Landroid_content_Context_Lcom_tencent_open_c_a_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Lcom_tencent_open_c_a_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/content/Context;Lcom/tencent/open/c$a;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_a_Landroid_content_Context_Lcom_tencent_open_c_a_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Landroid/content/Context;Lcom/tencent/open/c$a;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_b;
#pragma warning disable 0169
		static Delegate GetBHandler ()
		{
			if (cb_b == null)
				cb_b = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_B);
			return cb_b;
		}

		static void n_B (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Open.C __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.C> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.B ();
		}
#pragma warning restore 0169

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='c']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()V", "GetBHandler")]
		public virtual unsafe void B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_b);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "b", "()V"));
			} finally {
			}
		}

	}
}
