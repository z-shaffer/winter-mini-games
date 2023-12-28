using UnityEngine;

public interface IKitchenObjectParent
{
    public Transform GetKitchenObjectFollowTransform();

    public void SetKitchenObject(KitchenObject kitchenObject);

    public KitchenObject GetKitchenObject(KitchenObject kitchen);

    public void ClearKitchenObject();

    public bool HasKitchenObject();
}