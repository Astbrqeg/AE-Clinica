using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.OleDb;
/// <summary>
/// Summary description for Connector
/// </summary>
/// 

public class Connector
{
    //------------------------------------ For Access Connection -----------------//
    private OleDbConnection aConnection;
    private OleDbCommand aCommand;
    private string connect_string;
    private string the_exception;
    private OleDbDataAdapter oda;
    private DataSet ds = new DataSet();

    //------------------------------------------- Constructors ------------------------//
    public Connector(string dbName)
    {
        //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=
        this.connect_string = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbName;
        this.aConnection = new OleDbConnection(this.connect_string);
    }
    public Connector()
    {
        this.connect_string = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="  + "Database.mdb";
        this.aConnection = new OleDbConnection(this.connect_string);
    }

    //---------------------------------------* Methods *---------------------------------------//
    public OleDbConnection OpenConn()
    {
        if (this.aConnection.State == ConnectionState.Closed || this.aConnection.State == ConnectionState.Broken)
        {
            this.aConnection.Open();
        }
        return this.aConnection;
    }

    public OleDbConnection CloseConn()
    {
        if (this.aConnection.State == ConnectionState.Open)
        {
            this.aConnection.Close();
        }
        return this.aConnection;
    }

    public string GetError()
    {
        return this.the_exception;
    }

    public OleDbDataReader RunSelect(string sql)
    {
        this.aConnection.Close();
        OleDbDataReader aReader = null;
        aCommand = new OleDbCommand(sql, aConnection);
        try
        {
            this.aConnection.Open();
            aReader = this.aCommand.ExecuteReader();

        }
        catch (Exception err)
        {
            this.the_exception = err.Message;
        }

        finally
        {
            this.aCommand = null;
        }

        return aReader;
    }

    public int RunUpdateInsertDelete(string sql)
    {

        int r = -1;
        this.aCommand = new OleDbCommand(sql, aConnection);
        try
        {
            this.aConnection.Open();
            r = this.aCommand.ExecuteNonQuery();
            this.aConnection.Close();
        }
        catch (Exception err)
        {
            this.the_exception = err.Message;
        }
        finally
        {
            this.aCommand = null;
        }
        return r;

    }

    public DataSet returnOledbDataSet(string txtQuery)
    {
        this.aConnection.Close();
        this.aConnection.Open();
        this.aCommand = aConnection.CreateCommand();
        this.oda = new OleDbDataAdapter(txtQuery, aConnection);
        this.ds.Reset();
        this.oda.Fill(ds);
        this.aConnection.Close();
        return (ds);
    }

    public DataTable returnOledbDataTable(string txtQuery)
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter adap;
        try
        {
            cmd.Connection = this.OpenConn();
            cmd.CommandText = txtQuery;
            adap = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adap.Fill(dt);

            return dt;
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            cmd = null;
        }
    }


    public void ExecuteQuery(string txtQuery)
    {
        OleDbCommand cmd = new OleDbCommand();
        try
        {
            cmd.Connection = this.OpenConn();
            cmd.CommandText = txtQuery;
            cmd.ExecuteNonQuery();
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            cmd = null;
        }
    }
}