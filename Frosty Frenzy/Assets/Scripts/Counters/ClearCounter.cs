using UnityEngine;

public class ClearCounter : BaseCounter
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    public override void Interact(Player player)
    {
        if (!HasKitchenObject())
        {
            // No kitchen object
            if (player.HasKitchenObject())
            {
                // Player is carrying something
                player.GetKitchenObject().SetKitchenObjectParent(this); 
            }
            else
            {
                // Player is carrying nothing
            }
        }
        else
        {
            if (player.HasKitchenObject())
            {
                // Player is carrying something
            }
            else
            {
                // Player is carrying nothing
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }
}
