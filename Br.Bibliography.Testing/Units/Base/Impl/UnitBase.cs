using Br.Bibliography.Core.Exceptions;
using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Testing.Records.Base.Interfaces;
using Br.Bibliography.Testing.Units.Base.Interfaces;
using Br.Bibliography.Web.Controllers.Base.Interfaces;
using Br.Bibliography.Web.Packets.Base.Interfaces;

namespace Br.Bibliography.Testing.Units.Base.Impl
{
    public abstract class UnitBase<TEntity, TRecord, TPacket, TController> : Unit, IUnitBase<TEntity, TRecord, TPacket, TController>
            where TController : IControllerBase<TEntity, TPacket>
            where TPacket : IPacketBase<TEntity>
            where TRecord : IRecordBase<TEntity>
            where TEntity : EntityBase<TEntity>, new()
    {

        #region Dependencies

        public abstract TController Controller { get; init; }

        public abstract TRecord Record { get; init; }

        #endregion

        #region Constructors

        protected UnitBase(TController controller, TRecord record)
        {
            Controller = controller;
            Record = record;
        }

        #endregion

        #region Helpers

        private void SuccessCreate(TEntity? entity)
        {
            if (entity == null) throw ExceptionControllerHandleCreate<TEntity>.Throw(entity);
            try
            {
                // Act
                var packet = Controller.HandleCreate(entity);

                // Assert
                Assert.NotNull(packet);
                Assert.True(packet.Key > 0);
            }
            catch (Exception ex)
            {
                // Assert
                Assert.IsType<NullReferenceException>(ex);
            }
        }

        private void ErrorCreate(TEntity? entity)
        {
            try
            {
                // Arrange
                Assert.Null(entity);

                // Act
                var packet = Controller.HandleCreate(entity);
            }
            catch (ExceptionControllerHandleCreate<TEntity> ex)
            {
                // Assert
                Assert.Null(ex.Entity);
            }
        }

        #endregion

        #region Success

        #region Create

        [Fact]
        public void SuccessCreateEntityBaseDefault() => SuccessCreate(Record.EntityBaseDefault);

        [Fact]
        public void SuccessCreateEntityBaseZeroKey() => SuccessCreate(Record.EntityBaseZeroKey);

        [Fact]
        public void SuccessCreateEntityBaseMinKey() => SuccessCreate(Record.EntityBaseMinKey);

        [Fact]
        public void SuccessCreateEntityBaseMaxKey() => SuccessCreate(Record.EntityBaseMaxKey);

        [Fact]
        public void SuccessCreateEntityBaseRandomKey() => SuccessCreate(Record.EntityBaseRandomKey);

        #endregion

        #endregion

        #region Errors

        #region Create

        [Fact]
        public void ErrorCreateEntityBaseNull() => ErrorCreate(Record.EntityBaseNull);

        #endregion

        #endregion
    }
}