function my_function(message) {
    console.log("from utilities " + message);
}

function dotnetStaticInvocation() {
    DotNet.invokeMethodAsync("BlazorApp.Client", "GetCurrentCount")
        .then(result => {
            console.log("count from js " + result);
        });
}

function dotnetInstanceInvocation(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");
}