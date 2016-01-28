InboxSDK.load('1.0', 'sdk_LoonyTestSdk2_e0399f0675').then(function (sdk) {

	// the SDK has been loaded, now do something with it!
	sdk.Compose.registerComposeViewHandler(function(composeView) {



		// a compose view has come into existence, do something with it!
		composeView.addButton({
			title: "My Nifty Button!",
			iconUrl: 'https://raw.githubusercontent.com/LoonyJester/GmailConnector/master/GmailConnectorExtention/content/cr.gif',
			onClick: function(event) {
				event.composeView.insertTextIntoBodyAtCursor('Hello World!');
			}
		});

	});
	var ddl = '<div>' +
	    'Some title: ' +
	    '<div> ' +
	    '<select> ' +
	    '<option selected="selected" value="0">Create</option> ' +
	    '<option  value="1">Ignore</option> ' +
	    '<option  value="2">Push</option> ' +
	    '<option  value="3">Create</option> ' +
	    '</select>' +
	    '</div> ' +
	    '<div> ' +
	    '<button onclick="alert([MessageId])">Clicl me</button> ' +
	    '</div> ' +
	    '</div>';

	sdk.Lists.registerThreadRowViewHandler(function (threadRowView) {

	    var min = 0;
	    var max = 3;

	    var index = Math.floor(Math.random() * (max - min + 1)) + min;
	    switch (index) {
	        case 0:
	            threadRowView.addImage({
	                imageUrl: "https://raw.githubusercontent.com/LoonyJester/GmailConnector/master/GmailConnectorExtention/content/ignore.gif",
	                tooltip: "Ignored"
	            });
	            break;
	        case 1:
	            threadRowView.addImage({
	                imageUrl: "https://raw.githubusercontent.com/LoonyJester/GmailConnector/master/GmailConnectorExtention/content/ticket.gif",
	                tooltip: "Ticket " + (Math.floor(Math.random() * (30200 - 30000 + 1)) + 30000)
	            });

	            break;
	        default :
	            threadRowView.addButton({
	                title: "My Action Button!",
	                iconUrl: "https://raw.githubusercontent.com/LoonyJester/GmailConnector/master/GmailConnectorExtention/content/create.gif",
	                onClick: function (event) {
	                    //	                    alert('onCreate ' + event);
	                    event.dropdown.el.innerHTML = ddl.replace("[MessageId]", "'For message with ThreadID " + event.threadRowView.getThreadID() +"'");
	                },
	                hasDropdown: true 
	            });
	            break;
	    }
	});

    sdk.Conversations.registerThreadViewHandler(function(threadView) {
        var el = document.createElement("div");
        el.innerHTML = '<img src="https://raw.githubusercontent.com/LoonyJester/GmailConnector/master/GmailConnectorExtention/content/ticket.gif" />';


        threadView.addSidebarContentPanel({
            title: 'The thread status',
            el: el
        });
    });

    sdk.Conversations.registerMessageViewHandler(function (messageView) {
        var min = 0;
        var max = 2;

        var index = Math.floor(Math.random() * (max - min + 1)) + min;

        switch (index) {
            case 0:
                messageView.addAttachmentIcon({
                    iconUrl: "https://raw.githubusercontent.com/LoonyJester/GmailConnector/master/GmailConnectorExtention/content/ignore.gif",
                    tooltip: "Ignored",
                                        onClick: function (event) {
                                            alert("Test click");

                    }
                });
//                messageView.addAttachmentsToolbarButton({
//                    iconUrl: "https://raw.githubusercontent.com/LoonyJester/GmailConnector/master/GmailConnectorExtention/content/ignore.gif",
//                    tooltip: "Ignored",
//                                        onClick: function (event) {
//                        //	                    alert('onCreate ' + event);
//                        event.dropdown.el.innerHTML = ddl.replace("[MessageId]", "'For message with ThreadID " + event.threadRowView.getThreadID() +"'");
//                    }
//                });
                break;
            case 1:
                messageView.addAttachmentIcon({
                    iconUrl: "https://raw.githubusercontent.com/LoonyJester/GmailConnector/master/GmailConnectorExtention/content/ticket.gif",
                    tooltip: "Ticket " + (Math.floor(Math.random() * (30200 - 30000 + 1)) + 30000),
                    onClick: function (event) {
                        alert("Test click");

                    }
                });
//                messageView.addAttachmentsToolbarButton({
//                    iconUrl: "https://raw.githubusercontent.com/LoonyJester/GmailConnector/master/GmailConnectorExtention/content/ticket.gif",
//                    tooltip: "Ticket " + (Math.floor(Math.random() * (30200 - 30000 + 1)) + 30000),
//                    onClick: function (event) {
//                        //	                    alert('onCreate ' + event);
//                        event.dropdown.el.innerHTML = ddl.replace("[MessageId]", "'For message with ThreadID " + event.threadRowView.getThreadID() + "'");
//                    }
//                });

                break;
            default :
                messageView.addAttachmentIcon({
                    title: "My Action Button!",
                    iconUrl: "https://raw.githubusercontent.com/LoonyJester/GmailConnector/master/GmailConnectorExtention/content/create.gif",
                    onClick: function (event) {
                        alert("Test click");
                    },
                    hasDropdown: true 
                });
//                messageView.addAttachmentsToolbarButton({
//                    title: "My Action Button!",
//                    iconUrl: "https://raw.githubusercontent.com/LoonyJester/GmailConnector/master/GmailConnectorExtention/content/create.gif",
//                    onClick: function (event) {
//                        //	                    alert('onCreate ' + event);
//                        event.dropdown.el.innerHTML = ddl.replace("[MessageId]", "'For message with ThreadID " + event.threadRowView.getThreadID() +"'");
//                    },
//                    hasDropdown: true 
//                });
                break;
        }


    });

});
