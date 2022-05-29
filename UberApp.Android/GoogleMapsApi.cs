﻿#if DEBUG
using System;
using Android.App;
using Android.Runtime;
using Plugin.CurrentActivity;
using UberApp.Conexiones;
[Application(Debuggable = true)]
#else
using Android.App;
using Android.RunTIme;
using Plugin.CurrentActivity;
using System;

[Application(Debuggable = false)]

#endif

[MetaData("com.google.android.maps.v2.API_KEY",Value = Constantes.ApiKeyMaps)]
public class GoogleMapsApi:Application
{
    public GoogleMapsApi(IntPtr handle,JniHandleOwnership transer)
        :base(handle,transer)
    {

    }
    public override void OnCreate()
    {
        base.OnCreate();
        CrossCurrentActivity.Current.Init(this);
    }
}