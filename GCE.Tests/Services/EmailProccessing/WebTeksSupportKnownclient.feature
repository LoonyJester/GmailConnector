Feature: Email Received to WebTeks Support from a Known Client Email(not WebTeks Domain)

Scenario: Start processing - save info about email
	Given A new email is received by WebTeks Support from a Known Client Email
	Then The Email Connector functionality gets the new message from mailgun.com 
	When it should create a new record in the Email Connector DB
	And Primary-ID (message-id) = a unique message identifier from Email Header(Message-ID) is saved
	And Message-ID = a unique message identifier from Email Header is saved
	And Email message content is saved
	And timestamp is saved
	


Scenario: Check first ref reference
	Given A new email is received by WebTeks Support from a Known Client Email
	Then The Email Connector functionality gets the new message from mailgun.com
	And Record  in the Email Connector DB exist
	And Email has references
	When it should check the references for the first value

	 