using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Open.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ThreadManager']"
	[global::Android.Runtime.Register ("com/tencent/open/utils/ThreadManager", DoNotGenerateAcw=true)]
	public sealed partial class ThreadManager : global::Java.Lang.Object {


		static IntPtr NETWORK_EXECUTOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ThreadManager']/field[@name='NETWORK_EXECUTOR']"
		[Register ("NETWORK_EXECUTOR")]
		public static global::Java.Util.Concurrent.IExecutor NetworkExecutor {
			get {
				if (NETWORK_EXECUTOR_jfieldId == IntPtr.Zero)
					NETWORK_EXECUTOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_EXECUTOR", "Ljava/util/concurrent/Executor;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NETWORK_EXECUTOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutor> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ThreadManager.SerialExecutor']"
		[global::Android.Runtime.Register ("com/tencent/open/utils/ThreadManager$SerialExecutor", DoNotGenerateAcw=true)]
		public partial class SerialExecutor : global::Java.Lang.Object, global::Java.Util.Concurrent.IExecutor {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/open/utils/ThreadManager$SerialExecutor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SerialExecutor); }
			}

			protected SerialExecutor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_a;
#pragma warning disable 0169
			static Delegate GetAHandler ()
			{
				if (cb_a == null)
					cb_a = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_A);
				return cb_a;
			}

			static void n_A (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.Open.Utils.ThreadManager.SerialExecutor __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Utils.ThreadManager.SerialExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.A ();
			}
#pragma warning restore 0169

			static IntPtr id_a;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ThreadManager.SerialExecutor']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()V", "GetAHandler")]
			protected virtual unsafe void A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetMethodID (class_ref, "a", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_a);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "()V"));
				} finally {
				}
			}

			static Delegate cb_execute_Ljava_lang_Runnable_;
#pragma warning disable 0169
			static Delegate GetExecute_Ljava_lang_Runnable_Handler ()
			{
				if (cb_execute_Ljava_lang_Runnable_ == null)
					cb_execute_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Execute_Ljava_lang_Runnable_);
				return cb_execute_Ljava_lang_Runnable_;
			}

			static void n_Execute_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Open.Utils.ThreadManager.SerialExecutor __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Utils.ThreadManager.SerialExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Execute (p0);
			}
#pragma warning restore 0169

			static IntPtr id_execute_Ljava_lang_Runnable_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ThreadManager.SerialExecutor']/method[@name='execute' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
			[Register ("execute", "(Ljava/lang/Runnable;)V", "GetExecute_Ljava_lang_Runnable_Handler")]
			public virtual unsafe void Execute (global::Java.Lang.IRunnable p0)
			{
				if (id_execute_Ljava_lang_Runnable_ == IntPtr.Zero)
					id_execute_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "execute", "(Ljava/lang/Runnable;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_execute_Ljava_lang_Runnable_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execute", "(Ljava/lang/Runnable;)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/open/utils/ThreadManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ThreadManager); }
		}

		internal ThreadManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ThreadManager']/constructor[@name='ThreadManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ThreadManager ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ThreadManager)) {
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

		static IntPtr id_getFileThreadHandler;
		public static unsafe global::Android.OS.Handler FileThreadHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ThreadManager']/method[@name='getFileThreadHandler' and count(parameter)=0]"
			[Register ("getFileThreadHandler", "()Landroid/os/Handler;", "GetGetFileThreadHandlerHandler")]
			get {
				if (id_getFileThreadHandler == IntPtr.Zero)
					id_getFileThreadHandler = JNIEnv.GetStaticMethodID (class_ref, "getFileThreadHandler", "()Landroid/os/Handler;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFileThreadHandler), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getFileThreadLooper;
		public static unsafe global::Android.OS.Looper FileThreadLooper {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ThreadManager']/method[@name='getFileThreadLooper' and count(parameter)=0]"
			[Register ("getFileThreadLooper", "()Landroid/os/Looper;", "GetGetFileThreadLooperHandler")]
			get {
				if (id_getFileThreadLooper == IntPtr.Zero)
					id_getFileThreadLooper = JNIEnv.GetStaticMethodID (class_ref, "getFileThreadLooper", "()Landroid/os/Looper;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.OS.Looper> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFileThreadLooper), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getMainHandler;
		public static unsafe global::Android.OS.Handler MainHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ThreadManager']/method[@name='getMainHandler' and count(parameter)=0]"
			[Register ("getMainHandler", "()Landroid/os/Handler;", "GetGetMainHandlerHandler")]
			get {
				if (id_getMainHandler == IntPtr.Zero)
					id_getMainHandler = JNIEnv.GetStaticMethodID (class_ref, "getMainHandler", "()Landroid/os/Handler;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMainHandler), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSubThread;
		public static unsafe global::Java.Lang.Thread SubThread {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ThreadManager']/method[@name='getSubThread' and count(parameter)=0]"
			[Register ("getSubThread", "()Ljava/lang/Thread;", "GetGetSubThreadHandler")]
			get {
				if (id_getSubThread == IntPtr.Zero)
					id_getSubThread = JNIEnv.GetStaticMethodID (class_ref, "getSubThread", "()Ljava/lang/Thread;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSubThread), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSubThreadHandler;
		public static unsafe global::Android.OS.Handler SubThreadHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ThreadManager']/method[@name='getSubThreadHandler' and count(parameter)=0]"
			[Register ("getSubThreadHandler", "()Landroid/os/Handler;", "GetGetSubThreadHandlerHandler")]
			get {
				if (id_getSubThreadHandler == IntPtr.Zero)
					id_getSubThreadHandler = JNIEnv.GetStaticMethodID (class_ref, "getSubThreadHandler", "()Landroid/os/Handler;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSubThreadHandler), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSubThreadLooper;
		public static unsafe global::Android.OS.Looper SubThreadLooper {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ThreadManager']/method[@name='getSubThreadLooper' and count(parameter)=0]"
			[Register ("getSubThreadLooper", "()Landroid/os/Looper;", "GetGetSubThreadLooperHandler")]
			get {
				if (id_getSubThreadLooper == IntPtr.Zero)
					id_getSubThreadLooper = JNIEnv.GetStaticMethodID (class_ref, "getSubThreadLooper", "()Landroid/os/Looper;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.OS.Looper> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSubThreadLooper), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_executeOnFileThread_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ThreadManager']/method[@name='executeOnFileThread' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("executeOnFileThread", "(Ljava/lang/Runnable;)V", "")]
		public static unsafe void ExecuteOnFileThread (global::Java.Lang.IRunnable p0)
		{
			if (id_executeOnFileThread_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_executeOnFileThread_Ljava_lang_Runnable_ = JNIEnv.GetStaticMethodID (class_ref, "executeOnFileThread", "(Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_executeOnFileThread_Ljava_lang_Runnable_, __args);
			} finally {
			}
		}

		static IntPtr id_executeOnNetWorkThread_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ThreadManager']/method[@name='executeOnNetWorkThread' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("executeOnNetWorkThread", "(Ljava/lang/Runnable;)V", "")]
		public static unsafe void ExecuteOnNetWorkThread (global::Java.Lang.IRunnable p0)
		{
			if (id_executeOnNetWorkThread_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_executeOnNetWorkThread_Ljava_lang_Runnable_ = JNIEnv.GetStaticMethodID (class_ref, "executeOnNetWorkThread", "(Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_executeOnNetWorkThread_Ljava_lang_Runnable_, __args);
			} finally {
			}
		}

		static IntPtr id_executeOnSubThread_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ThreadManager']/method[@name='executeOnSubThread' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("executeOnSubThread", "(Ljava/lang/Runnable;)V", "")]
		public static unsafe void ExecuteOnSubThread (global::Java.Lang.IRunnable p0)
		{
			if (id_executeOnSubThread_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_executeOnSubThread_Ljava_lang_Runnable_ = JNIEnv.GetStaticMethodID (class_ref, "executeOnSubThread", "(Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_executeOnSubThread_Ljava_lang_Runnable_, __args);
			} finally {
			}
		}

		static IntPtr id_init;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ThreadManager']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "")]
		public static unsafe void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetStaticMethodID (class_ref, "init", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_init);
			} finally {
			}
		}

		static IntPtr id_newSerialExecutor;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ThreadManager']/method[@name='newSerialExecutor' and count(parameter)=0]"
		[Register ("newSerialExecutor", "()Ljava/util/concurrent/Executor;", "")]
		public static unsafe global::Java.Util.Concurrent.IExecutor NewSerialExecutor ()
		{
			if (id_newSerialExecutor == IntPtr.Zero)
				id_newSerialExecutor = JNIEnv.GetStaticMethodID (class_ref, "newSerialExecutor", "()Ljava/util/concurrent/Executor;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newSerialExecutor), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
