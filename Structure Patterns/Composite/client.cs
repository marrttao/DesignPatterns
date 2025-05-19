namespace Structure_Patterns.Composite;

public class client
{
    public void Run()
    {

        var abilityIcon1 = new Icon("Q - Tornado");
        var abilityIcon2 = new Icon("W - EMP");
        var abilitiesPanel = new Panel("Abilities");
        abilitiesPanel.Add(abilityIcon1);
        abilitiesPanel.Add(abilityIcon2);
        var inventoryPanel = new Panel("Inventory");
        inventoryPanel.Add(new Icon("Item: Blink Dagger"));
        inventoryPanel.Add(new Icon("Item: Black King Bar"));
        var mainUIPanel = new Panel("Main UI");
        mainUIPanel.Add(abilitiesPanel);
        mainUIPanel.Add(inventoryPanel);
        mainUIPanel.Render();

    }
}