using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Connect.Dataprovider {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='DataType']"
	[global::Android.Runtime.Register ("com/tencent/connect/dataprovider/DataType", DoNotGenerateAcw=true)]
	public sealed partial class DataType : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='DataType']/field[@name='CONTENT_AND_IMAGE_PATH']"
		[Register ("CONTENT_AND_IMAGE_PATH")]
		public const int ContentAndImagePath = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='DataType']/field[@name='CONTENT_AND_VIDEO_PATH']"
		[Register ("CONTENT_AND_VIDEO_PATH")]
		public const int ContentAndVideoPath = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='DataType']/field[@name='CONTENT_ONLY']"
		[Register ("CONTENT_ONLY")]
		public const int ContentOnly = (int) 4;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='DataType.TextAndMediaPath']"
		[global::Android.Runtime.Register ("com/tencent/connect/dataprovider/DataType$TextAndMediaPath", DoNotGenerateAcw=true)]
		public partial class TextAndMediaPath : global::Java.Lang.Object, global::Android.OS.IParcelable {


			static IntPtr CREATOR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='DataType.TextAndMediaPath']/field[@name='CREATOR']"
			[Register ("CREATOR")]
			public static global::Android.OS.IParcelableCreator Creator {
				get {
					if (CREATOR_jfieldId == IntPtr.Zero)
						CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/connect/dataprovider/DataType$TextAndMediaPath", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TextAndMediaPath); }
			}

			protected TextAndMediaPath (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='DataType.TextAndMediaPath']/constructor[@name='DataType.TextAndMediaPath' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe TextAndMediaPath (string p0, string p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					if (GetType () != typeof (TextAndMediaPath)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_getMediaPath;
#pragma warning disable 0169
			static Delegate GetGetMediaPathHandler ()
			{
				if (cb_getMediaPath == null)
					cb_getMediaPath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMediaPath);
				return cb_getMediaPath;
			}

			static IntPtr n_GetMediaPath (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.Connect.Dataprovider.DataType.TextAndMediaPath __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Dataprovider.DataType.TextAndMediaPath> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.MediaPath);
			}
#pragma warning restore 0169

			static IntPtr id_getMediaPath;
			public virtual unsafe string MediaPath {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='DataType.TextAndMediaPath']/method[@name='getMediaPath' and count(parameter)=0]"
				[Register ("getMediaPath", "()Ljava/lang/String;", "GetGetMediaPathHandler")]
				get {
					if (id_getMediaPath == IntPtr.Zero)
						id_getMediaPath = JNIEnv.GetMethodID (class_ref, "getMediaPath", "()Ljava/lang/String;");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMediaPath), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMediaPath", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getText;
#pragma warning disable 0169
			static Delegate GetGetTextHandler ()
			{
				if (cb_getText == null)
					cb_getText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetText);
				return cb_getText;
			}

			static IntPtr n_GetText (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.Connect.Dataprovider.DataType.TextAndMediaPath __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Dataprovider.DataType.TextAndMediaPath> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Text);
			}
#pragma warning restore 0169

			static IntPtr id_getText;
			public virtual unsafe string Text {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='DataType.TextAndMediaPath']/method[@name='getText' and count(parameter)=0]"
				[Register ("getText", "()Ljava/lang/String;", "GetGetTextHandler")]
				get {
					if (id_getText == IntPtr.Zero)
						id_getText = JNIEnv.GetMethodID (class_ref, "getText", "()Ljava/lang/String;");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getText), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_describeContents;
#pragma warning disable 0169
			static Delegate GetDescribeContentsHandler ()
			{
				if (cb_describeContents == null)
					cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
				return cb_describeContents;
			}

			static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.Connect.Dataprovider.DataType.TextAndMediaPath __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Dataprovider.DataType.TextAndMediaPath> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.DescribeContents ();
			}
#pragma warning restore 0169

			static IntPtr id_describeContents;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='DataType.TextAndMediaPath']/method[@name='describeContents' and count(parameter)=0]"
			[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
			public virtual unsafe int DescribeContents ()
			{
				if (id_describeContents == IntPtr.Zero)
					id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_describeContents);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
				} finally {
				}
			}

			static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
			static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
			{
				if (cb_writeToParcel_Landroid_os_Parcel_I == null)
					cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
				return cb_writeToParcel_Landroid_os_Parcel_I;
			}

			static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
			{
				global::Com.Tencent.Connect.Dataprovider.DataType.TextAndMediaPath __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Dataprovider.DataType.TextAndMediaPath> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
				__this.WriteToParcel (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='DataType.TextAndMediaPath']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
			[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
			public virtual unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
			{
				if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
					id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue ((int) p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='DataType.TextOnly']"
		[global::Android.Runtime.Register ("com/tencent/connect/dataprovider/DataType$TextOnly", DoNotGenerateAcw=true)]
		public partial class TextOnly : global::Java.Lang.Object, global::Android.OS.IParcelable {


			static IntPtr CREATOR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='DataType.TextOnly']/field[@name='CREATOR']"
			[Register ("CREATOR")]
			public static global::Android.OS.IParcelableCreator Creator {
				get {
					if (CREATOR_jfieldId == IntPtr.Zero)
						CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/connect/dataprovider/DataType$TextOnly", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TextOnly); }
			}

			protected TextOnly (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='DataType.TextOnly']/constructor[@name='DataType.TextOnly' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe TextOnly (string p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					if (GetType () != typeof (TextOnly)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_getText;
#pragma warning disable 0169
			static Delegate GetGetTextHandler ()
			{
				if (cb_getText == null)
					cb_getText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetText);
				return cb_getText;
			}

			static IntPtr n_GetText (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.Connect.Dataprovider.DataType.TextOnly __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Dataprovider.DataType.TextOnly> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Text);
			}
#pragma warning restore 0169

			static IntPtr id_getText;
			public virtual unsafe string Text {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='DataType.TextOnly']/method[@name='getText' and count(parameter)=0]"
				[Register ("getText", "()Ljava/lang/String;", "GetGetTextHandler")]
				get {
					if (id_getText == IntPtr.Zero)
						id_getText = JNIEnv.GetMethodID (class_ref, "getText", "()Ljava/lang/String;");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getText), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_describeContents;
#pragma warning disable 0169
			static Delegate GetDescribeContentsHandler ()
			{
				if (cb_describeContents == null)
					cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
				return cb_describeContents;
			}

			static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.Connect.Dataprovider.DataType.TextOnly __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Dataprovider.DataType.TextOnly> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.DescribeContents ();
			}
#pragma warning restore 0169

			static IntPtr id_describeContents;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='DataType.TextOnly']/method[@name='describeContents' and count(parameter)=0]"
			[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
			public virtual unsafe int DescribeContents ()
			{
				if (id_describeContents == IntPtr.Zero)
					id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_describeContents);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
				} finally {
				}
			}

			static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
			static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
			{
				if (cb_writeToParcel_Landroid_os_Parcel_I == null)
					cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
				return cb_writeToParcel_Landroid_os_Parcel_I;
			}

			static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
			{
				global::Com.Tencent.Connect.Dataprovider.DataType.TextOnly __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Dataprovider.DataType.TextOnly> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
				__this.WriteToParcel (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='DataType.TextOnly']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
			[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
			public virtual unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
			{
				if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
					id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue ((int) p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/connect/dataprovider/DataType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DataType); }
		}

		internal DataType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='DataType']/constructor[@name='DataType' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DataType ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DataType)) {
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

	}
}
