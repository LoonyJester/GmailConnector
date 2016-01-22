InboxSDK.load('1.0', 'sdk_LoonyTestSdk2_e0399f0675').then(function (sdk) {

	// the SDK has been loaded, now do something with it!
	sdk.Compose.registerComposeViewHandler(function(composeView){

		// a compose view has come into existence, do something with it!
		composeView.addButton({
			title: "My Nifty Button!4",
			iconUrl: '../content/cr.gif',
			onClick: function(event) {
				event.composeView.insertTextIntoBodyAtCursor('Hello World!');
			}
		});

	});

});
