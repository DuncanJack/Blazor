window.invokeNET = {
    returnArrayAsyncJs: function () {
        // Assembly, StaticMethodName
        DotNet.invokeMethodAsync('JavaScriptInterop', 'ReturnArrayAsync')
            .then(data => {
                data.push(4);
                console.log(data);
            });
    },
    sayHello: function (instance) {
        // Call a method on the C# instance that is passed in.
        return instance.invokeMethodAsync('SayHello')
            .then(r => console.log(r));
    }
};