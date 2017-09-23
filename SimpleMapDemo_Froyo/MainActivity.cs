namespace SimpleMapDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Android.App;
    using Android.Content;
    using Android.OS;
    using Android.Views;
    using Android.Widget;

    using AndroidUri = Android.Net.Uri;

    [Activity(Label = "@string/app_name", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SampleActivity sa = new SampleActivity(Resource.String.basic_map, Resource.String.basic_map_description, typeof(BasicDemoActivity));
            sa.Start(this);
        }

        internal class SampleActivity
        {
            public SampleActivity(int titleResourceId, int descriptionId, Type activityToLaunch)
            {
                ActivityToLaunch = activityToLaunch;
                TitleResource = titleResourceId;
                DescriptionResource = descriptionId;
            }

            public Type ActivityToLaunch { get; private set; }
            public int DescriptionResource { get; private set; }
            public int TitleResource { get; private set; }

            public void Start(Activity context)
            {
                Intent i = new Intent(context, ActivityToLaunch);
                context.StartActivity(i);
            }
        }


    }
}