namespace Problem_06.Animals
{
    interface IAnimal : ISoundProducible
    {
        string Name { get; }
        long Age { get; }
        Gender Gender { get; }
    }
}
