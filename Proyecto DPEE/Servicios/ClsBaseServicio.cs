using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_DPEE.Servicios
{
    public class ClsBaseServicio : IDisposable
    {

        #region -  PROPIEDADES  -
        protected readonly string _ConnectionString;
        private SqlConnection _SqlConexion;
        private SqlDataAdapter _SqlAdapter;
        protected SqlCommand _SqlCommand;
        private bool _DisposeValue = false;

        /// <summary>
        ///     Retorno de transaccion para peticiones "anidadas"
        /// </summary>
        private SqlTransaction _SqlTransac;
        public SqlTransaction Transaccion => _SqlTransac;

        /// <summary>
        ///     Retorno de resultado de la petición en DataTable
        /// </summary>
        protected DataTable _Data;
        public DataTable DtResultados => _Data;

        /// <summary>
        ///     Retorno de resultado de la petición en DataSet
        /// </summary>
        protected DataSet _Ds;
        public DataSet DsResultados => _Ds;

        // MANEJO DE ERRORES
        protected bool _TieneError;
        public bool TieneError => _TieneError;

        protected string _MsgError;
        public string MsgError => _MsgError;

        protected int _MsgCode;
        public int MsgCode => _MsgCode;

        protected int _NumberCode;
        public int NumberCode => _NumberCode;

        #endregion


        //CONSTRUCTOR
        protected ClsBaseServicio(string connectionString = null, SqlTransaction transaccionCompartida = null)
        {
            _ConnectionString = connectionString ?? ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;

            if (transaccionCompartida == null)
            {
                _SqlConexion = new SqlConnection(_ConnectionString);
            }
            else
            {
                _SqlConexion = transaccionCompartida.Connection;
                _SqlTransac = transaccionCompartida;
            }

            _SqlAdapter = new SqlDataAdapter();
            _SqlCommand = new SqlCommand();
        }


        #region -  CONEXION DB  -

        protected void InicializaCommand(string strSQL, CommandType tipoComando = CommandType.StoredProcedure)
        {
            _SqlCommand.CommandType = tipoComando;
            _SqlCommand.CommandText = strSQL;
            _SqlCommand.Parameters.Clear();

            if (_SqlTransac != null)
            {
                _SqlCommand.Transaction = _SqlTransac;
            }
        }

        private bool OpenConnection()
        {
            if (_SqlConexion.State == ConnectionState.Open)
            {
                _SqlCommand.Connection = _SqlConexion;
                return true;
            }

            try
            {
                _SqlConexion.Open();
                _SqlCommand.Connection = _SqlConexion;
                return true;
            }
            catch (Exception ex)
            {
                _TieneError = true;
                _MsgError = $"Ocurrió un error al intentar conectarse a la base de datos. Detalle: {ex}";
                return false;
            }
        }

        protected bool ExecData()
        {
            if (!OpenConnection())
            {
                return false;
            }

            try
            {
                _SqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (SqlException sqlEx)
            {
                _TieneError = true;
                _MsgCode = sqlEx.ErrorCode;
                _NumberCode = sqlEx.Number;
                _MsgError = sqlEx.Message.ToString();
                return false;
            }
            catch (Exception ex)
            {
                _TieneError = true;
                _MsgError = ex.ToString();
                return false;
            }

        }

        protected bool GetData()
        {
            if (!OpenConnection())
            {
                return false;
            }

            _Data = new DataTable();
            _SqlAdapter.SelectCommand = _SqlCommand;
            try
            {
                _SqlAdapter.Fill(_Data);
                return true;
            }
            catch (SqlException sqlEx)
            {
                _TieneError = true;
                _MsgCode = sqlEx.ErrorCode;
                _NumberCode = sqlEx.Number;
                _MsgError = sqlEx.Message.ToString();
                return false;
            }
            catch (Exception ex)
            {
                _TieneError = true;
                _MsgError = ex.ToString();
                return false;
            }

        }

        protected bool GetDataSet()
        {
            if (!OpenConnection())
            {
                return false;
            }

            _Ds = new DataSet();
            _SqlAdapter.SelectCommand = _SqlCommand;
            try
            {
                _SqlAdapter.Fill(_Ds);
                return true;
            }
            catch (SqlException sqlEx)
            {
                _TieneError = true;
                _MsgCode = sqlEx.ErrorCode;
                _NumberCode = sqlEx.Number;
                _MsgError = sqlEx.Message.ToString();
                return false;
            }
            catch (Exception ex)
            {
                _TieneError = true;
                _MsgError = ex.ToString();
                return false;
            }

        }
        #endregion

        #region -  MANEJO DE TRANSACCIONES  -
        public SqlTransaction IniciaTransaccion()
        {
            OpenConnection();
            if (_SqlTransac == null)
            {
                _SqlTransac = _SqlConexion.BeginTransaction();
            }
            return _SqlTransac;
        }

        public void RollBack()
        {
            _SqlTransac.Rollback();
        }
        public void Commit()
        {
            _SqlTransac.Commit();
        }
        #endregion

        #region -  DISPOSE  -
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_DisposeValue)
            {
                if (disposing)
                {
                    if (_Data != null) _Data.Dispose();
                    if (_SqlAdapter != null) _SqlAdapter.Dispose();
                    if (_SqlCommand != null) _SqlCommand.Dispose();
                    if (_SqlConexion.State != ConnectionState.Closed) _SqlConexion.Close();
                    if (_SqlConexion != null) _SqlConexion.Dispose();
                }
            }
            _DisposeValue = true;
        }
        #endregion

    }
}
