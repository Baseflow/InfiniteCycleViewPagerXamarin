using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V4.View;
using InfiniteCycleViewPager.Sample.Adapters;
using Com.Gigamole.Navigationtabstrip;

namespace InfiniteCycleViewPager.Sample
{
    [Activity(Label = "InfiniteCycleViewPager.Sample", MainLauncher = true, Icon = "@mipmap/icon", Theme="@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var viewPager = FindViewById<ViewPager>(Resource.Id.vp_main);
            viewPager.Adapter = new MainPagerAdapter(SupportFragmentManager);
            viewPager.OffscreenPageLimit = 2;

            var navigationTabStrip = FindViewById<NavigationTabStrip>(Resource.Id.nts);
            navigationTabStrip.SetTitles("HORIZONTAL", "VERTICAL", "TWO-WAY");
            navigationTabStrip.SetViewPager(viewPager);
        }
    }
}


