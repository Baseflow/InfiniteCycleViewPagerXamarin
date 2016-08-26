using System;
using Android.Support.V4.App;
using Com.Gigamole.Infinitecycleviewpager;
using InfiniteCycleViewPager.Sample.Adapters;

namespace InfiniteCycleViewPager.Sample.Screens
{
    public class VerticalPagerFragment : Fragment
    {
        public override Android.Views.View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.fragment_vertical, container, false);
        }

        public override void OnViewCreated(Android.Views.View view, Android.OS.Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);

            var verticalInfiniteCycleViewPager = view.FindViewById<VerticalInfiniteCycleViewPager>(Resource.Id.vicvp);
            verticalInfiniteCycleViewPager.Adapter = new VerticalPagerAdapter(Context, null);
        }
    }
}

