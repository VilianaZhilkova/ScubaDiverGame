namespace Assets.Scripts.Interfaces
{
    public interface IPlayer 
    {
        void Move(float speed, float horizontal, float vertical);
        void Flip(float horizontal);
        float[] GetHorizontalAndVertical();
    }
}
