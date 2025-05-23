// CAUTION: Manually guessed object based on the documentation. It does not need to be completely accurate.

namespace Alvao.API.Common.Model.CustomApps;

public class CommandResult {
    public MessageType MessageType { get; }
    public string MessageText { get; }
    public string NavigateToUrl { get; }

    public CommandResult(MessageType messageType, string messageText, string navigateToUrl) {
        MessageType = messageType;
        MessageText = messageText;
        NavigateToUrl = navigateToUrl;
    }
}
