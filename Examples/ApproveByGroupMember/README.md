# Approve By Group Member

Source: <https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/templates#approve-by-group-member>

When approval of a ticket gets started, this application automatically adds a member of a particular user group to the Approving tab of the ticket. The group member is chosen by the value of the Office field which must be equal to the value of the Office field of the ticket s requester.

To run the example, a custom field ApprovalGroupName of type nvarchar is assumed to be added to the TicketStateCust table.
