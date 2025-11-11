# Assign To Solver By Email

Source: <https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/templates/#assign-to-solver-by-email>

When a message is loaded, the message text for an existing ticket is examined for a command to pass to the solver ASSIGNTO: solver name. If the command is found and the solver is found by name, the ticket is automatically assigned to the solver and the message is not logged in the ticket log. Otherwise, the message is processed in the standard way.
