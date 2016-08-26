using System;
using Android.Support.V4.App;
using Com.Gigamole.Infinitecycleviewpager;
using InfiniteCycleViewPager.Sample.Adapters;

namespace InfiniteCycleViewPager.Sample.Screens
{
    public class HorizontalPagerFragment : Fragment
    {
        public override Android.Views.View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.fragment_horizontal, container, false);
        }

        public override void OnViewCreated(Android.Views.View view, Android.OS.Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);

            var horizontalInfiniteCycleViewPager = view.FindViewById<HorizontalInfiniteCycleViewPager>(Resource.Id.hicvp);
            horizontalInfiniteCycleViewPager.Adapter = new HorizontalPagerAdapter(Context, false);
        }
    }
}

