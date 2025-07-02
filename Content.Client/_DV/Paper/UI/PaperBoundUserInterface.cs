using Content.Client.Chat.TypingIndicator;
using Content.Shared.Chat.TypingIndicator;
using Robust.Shared.Prototypes;

namespace Content.Client.Paper.UI;

public sealed partial class PaperBoundUserInterface
{
    private static readonly ProtoId<TypingIndicatorPrototype> TypingIndicator = "paper";

    private TypingIndicatorSystem? _typing;

    private void OnTyping()
    {
        _typing ??= EntMan.System<TypingIndicatorSystem>();
        _typing?.ClientAlternateTyping(TypingIndicator);
    }

    private void OnSubmit()
    {
        _typing ??= EntMan.System<TypingIndicatorSystem>();
        _typing?.ClientSubmittedChatText();
    }
}
