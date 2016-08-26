using System;
using Android.Content;
using Android.Views;
using Android.Widget;
using Com.Bumptech.Glide;

namespace InfiniteCycleViewPager.Sample.Utils
{
    public class LibraryObject
    {

        private string mUrl;
        private string mImage;
        private string[] mImages = null;

        public LibraryObject(string url, string image)
        {
            mUrl = url;
            mImage = image;
        }

        public LibraryObject(string url, string[] images)
        {
            mUrl = url;
            mImages = images;
        }

        public string getUrl()
        {
            return mUrl;
        }

        public string getImage()
        {
            return mImage;
        }

        public string[] getImages()
        {
            return mImages;
        }
    }

    public static class AppUtils
    {

        /* private static View.OnClickListener mOnImageClickListener = new View.OnClickListener() {
         @Override
         public void onClick(final View view)
         {
             IntentHelper.openUrlInBrowser(view.getContext(), (String)view.getTag(view.getId()));
         }*/

        public static void SetupImage(Context context, ImageView imageView, LibraryObject libraryObject)
        {
            SetupImage(context, imageView, libraryObject, -1);
        }

        public static void SetupImage(Context context, ImageView imageView, LibraryObject libraryObject, int position)
        {

            imageView.SetTag(imageView.Id, libraryObject.getUrl());

            //imageView.SetOnClickListener(mOnImageClickListener);
            /*
            Glide.With(context)
                    .Load(position == -1 ? libraryObject.getImage() : libraryObject.getImages()[position]).
                    .asBitmap()
                    .centerCrop()
                    .listener(new RequestListener<String, Bitmap>() {
                    @Override
                        public boolean onException(final Exception e, final String model, final Target<Bitmap> target, final boolean isFirstResource)
        {
            return false;
        }

        @Override
                    public boolean onResourceReady(final Bitmap resource, final String model, final Target<Bitmap> target, final boolean isFromMemoryCache, final boolean isFirstResource)
        {
            final ImageViewTarget imageViewTarget = (ImageViewTarget)target;
            return new DrawableCrossFadeFactory<>()
                    .build(isFromMemoryCache, isFirstResource)
                    .animate(
                            new BitmapDrawable(
                                    imageViewTarget.getView().getResources(),
                                    resource
                            ),
                            imageViewTarget
                    );
        }
    })
                .into(imageView);*/
        }
    }
}