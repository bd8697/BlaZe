redirectToCheckOut = function (sesId) {
    var stripe = Stripe('pk_test_51IeEdwCjvNa00ldz2aDi3OPFqQmVGrnl9pV6ecXR3Nv03hrCF4eGawh0fUtNoHTI9asf0mRl89VwGOSsOIyuaQiz00AGjbZRri');
    stripe.redirectToCheckout({
        sessionId: sesId
    });
};
