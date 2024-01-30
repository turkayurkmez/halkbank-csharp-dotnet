namespace DILifeTime.Services
{
    public interface IGuidGenerator
    {
        Guid Guid { get; }
    }

    //Üç yöntem var: Singleton, Transient ve Scoped
    public interface ISingletonGuid : IGuidGenerator { }
    public interface ITransientGuid : IGuidGenerator { }
    public interface IScopedGuid : IGuidGenerator { }

    public class Singleton : ISingletonGuid
    {
        public Singleton()
        {
            Guid = Guid.NewGuid();
        }
        public Guid Guid { get; }
    }

    public class Scoped : IScopedGuid
    {
        public Scoped()
        {
            Guid = Guid.NewGuid();

        }
        public Guid Guid { get; }
    }

    public class Transient : ITransientGuid
    {
        public Transient()
        {
            Guid = Guid.NewGuid();

        }
        public Guid Guid { get; }
    }


    public class GuidService
    {

        public ISingletonGuid SingletonGuid { get; }
        public IScopedGuid ScopedGuid { get; }
        public ITransientGuid TransientGuid { get; }

        public GuidService(ISingletonGuid singletonGuid, IScopedGuid scopedGuid, ITransientGuid transientGuid)
        {

            SingletonGuid = singletonGuid;
            ScopedGuid = scopedGuid;
            TransientGuid = transientGuid;
        }


    }

}
