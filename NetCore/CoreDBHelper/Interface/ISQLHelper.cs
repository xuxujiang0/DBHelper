﻿using System;
using System.Collections.Generic;
using System.Data;

namespace DBHelper.Interface
{
    public interface ISQLHelper
    {
        string ConnectionString { get; set; }
        /// <summary>
        /// 执行sql命令，返回影响行数
        /// </summary>
        /// <param name="sqlText">数据库命令：存储过程名或sql语句</param>
        /// <param name="cmdType">命令类型</param>
        /// <param name="dictParams">参数</param>
        /// <returns></returns>
        //int ExecuteNonQuery(string sqlText, CommandType cmdType, IDictionary<string, object> dictParams);

        /// <summary>
        /// 执行sql命令，返回影响行数
        /// </summary>
        /// <param name="sqlText">数据库命令：存储过程名或sql语句</param>
        /// <param name="cmdType">命令类型</param>
        /// <param name="dictParams">参数</param>
        /// <param name="isUseTrans">是否使用事务</param>
        /// <returns></returns>
        int ExecuteNonQuery(string sqlText, CommandType cmdType, IDictionary<string, object> dictParams, bool isUseTrans);


        /// <summary>
        /// 执行sql命令，返回影响行数
        /// </summary>
        /// <param name="sqlText">数据库命令：存储过程名或sql语句</param>
        /// <param name="cmdType">命令类型</param>
        /// <param name="dictParams">参数</param>
        /// <param name="isUseTrans">是否使用事务</param>
        /// <returns></returns>
        int ExecuteNonQuery(string sqlText, CommandType cmdType, IEnumerable<IDictionary<string, object>> dictParams, bool isUseTrans);

        /// <summary>
        /// 执行sql命令，返回第一行第一列
        /// </summary>
        /// <param name="sqlText">数据库命令：存储过程名或sql语句</param>
        /// <param name="cmdType">命令类型</param>
        /// <param name="dictParams">参数</param>
        /// <returns></returns>
        //object ExecuteScalar(string sqlText, CommandType cmdType, IDictionary<string, object> dictParams);

        /// <summary>
        /// 执行sql命令，返回第一行第一列
        /// </summary>
        /// <param name="sqlText">数据库命令：存储过程名或sql语句</param>
        /// <param name="cmdType">命令类型</param>
        /// <param name="dictParams">参数</param>
        /// <returns></returns>
        //T ExecuteScalar<T>(string sqlText, CommandType cmdType, IDictionary<string, object> dictParams);

        /// <summary>
        /// 执行sql命令，返回第一行第一列
        /// </summary>
        /// <param name="sqlText">数据库命令：存储过程名或sql语句</param>
        /// <param name="cmdType">命令类型</param>
        /// <param name="dictParams">参数</param>
        /// <param name="isUseTrans">是否使用事务</param>
        /// <returns></returns>
        object ExecuteScalar(string sqlText, CommandType cmdType, IDictionary<string, object> dictParams, bool isUseTrans);

        /// <summary>
        /// 执行sql命令，返回第一行第一列
        /// </summary>
        /// <param name="sqlText">数据库命令：存储过程名或sql语句</param>
        /// <param name="cmdType">命令类型</param>
        /// <param name="dictParams">参数</param>
        /// <param name="isUseTrans">是否使用事务</param>
        /// <returns></returns>
        T ExecuteScalar<T>(string sqlText, CommandType cmdType, IDictionary<string, object> dictParams, bool isUseTrans);

        /// <summary>
        /// <summary>
        /// 执行sql命令，返回一条数据
        /// </summary>
        /// <param name="sqlText">数据库命令：存储过程名或sql语句</param>
        /// <param name="cmdType">命令类型</param>
        /// <param name="dictParams">参数</param>
        /// <returns></returns>
        IDataReader ExecuteReader(string sqlText, CommandType cmdType, IDictionary<string, object> dictParams);


        /// <summary>
        /// 执行sql命令，返回IEnumerable<dynamic>
        /// </summary>
        /// <param name="sqlText">数据库命令：存储过程名或sql语句</param>
        /// <param name="cmdType">命令类型</param>
        /// <param name="dictParams">参数</param>
        /// <returns></returns>
        IEnumerable<dynamic> QueryForList(string sqlText, CommandType cmdType, IDictionary<string, object> dictParams, bool isUseTrans);
        /// <summary>
        /// 执行sql命令，返回IEnumerable<T>
        /// </summary>
        /// <param name="sqlText">数据库命令：存储过程名或sql语句</param>
        /// <param name="cmdType">命令类型</param>
        /// <param name="dictParams">参数</param>
        /// <returns></returns>
        IEnumerable<T> QueryForList<T>(string sqlText, CommandType cmdType, IDictionary<string, object> dictParams, bool isUseTrans);

        /// <summary>
        /// 执行sql命令，返回dynamic
        /// </summary>
        /// <param name="sqlText">数据库命令：存储过程名或sql语句</param>
        /// <param name="cmdType">命令类型</param>
        /// <param name="dictParams">参数</param>
        /// <returns></returns>
        dynamic QueryForObject(string sqlText, CommandType cmdType, IDictionary<string, object> dictParams, bool isUseTrans);

        /// <summary>
        /// 执行sql命令，返回T
        /// </summary>
        /// <param name="sqlText">数据库命令：存储过程名或sql语句</param>
        /// <param name="cmdType">命令类型</param>
        /// <param name="dictParams">参数</param>
        /// <returns></returns>
        T QueryForObject<T>(string sqlText, CommandType cmdType, IDictionary<string, object> dictParams, bool isUseTrans);

        /// <summary>
        /// 返回结果集和数量 专用于分页
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sqlText"></param>
        /// <param name="cmdType"></param>
        /// <param name="dictParams"></param>
        /// <param name="total"></param>
        /// <param name="isUseTrans"></param>
        /// <returns></returns>
        IEnumerable<T> QueryMultipleByPage<T>(string sqlText, CommandType cmdType, IDictionary<string, object> dictParams, out int total, bool isUseTrans);

        /// <summary>
        /// 返回2个结果集
        /// </summary>
        /// <typeparam name="TFirst"></typeparam>
        /// <typeparam name="TSecond"></typeparam>
        /// <typeparam name="TReturn"></typeparam>
        /// <param name="sqlText"></param>
        /// <param name="cmdType"></param>
        /// <param name="dictParams"></param>
        /// <param name="func"></param>
        /// <param name="isUseTrans"></param>
        /// <returns></returns>
        IEnumerable<TReturn> QueryMultiple<TFirst, TSecond, TReturn>(string sqlText, CommandType cmdType, IDictionary<string, object> dictParams, Func<IEnumerable<TFirst>, IEnumerable<TSecond>, IEnumerable<TReturn>> func, bool isUseTrans);

        /// <summary>
        /// 返回3个结果集，通过委托
        /// </summary>
        /// <typeparam name="TFirst"></typeparam>
        /// <typeparam name="TSecond"></typeparam>
        /// <typeparam name="TReturn"></typeparam>
        /// <param name="sqlText"></param>
        /// <param name="cmdType"></param>
        /// <param name="dictParams"></param>
        /// <param name="func"></param>
        /// <param name="isUseTrans"></param>
        /// <returns></returns>
        IEnumerable<TReturn> QueryMultiple<TFirst, TSecond, TThird, TReturn>(string sqlText, CommandType cmdType, IDictionary<string, object> dictParams, Func<IEnumerable<TFirst>, IEnumerable<TSecond>, IEnumerable<TThird>, IEnumerable<TReturn>> func, bool isUseTrans);

        /// <summary>
        /// 返回4个结果集，通过委托
        /// </summary>
        /// <typeparam name="TFirst"></typeparam>
        /// <typeparam name="TSecond"></typeparam>
        /// <typeparam name="TReturn"></typeparam>
        /// <param name="sqlText"></param>
        /// <param name="cmdType"></param>
        /// <param name="dictParams"></param>
        /// <param name="func"></param>
        /// <param name="isUseTrans"></param>
        /// <returns></returns>
        IEnumerable<TReturn> QueryMultiple<TFirst, TSecond, TThird, TFourth, TReturn>(string sqlText, CommandType cmdType, IDictionary<string, object> dictParams, Func<IEnumerable<TFirst>, IEnumerable<TSecond>, IEnumerable<TThird>, IEnumerable<TFourth>, IEnumerable<TReturn>> func, bool isUseTrans);

        /// <summary>
        /// 返回5个结果集，通过委托
        /// </summary>
        /// <typeparam name="TFirst"></typeparam>
        /// <typeparam name="TSecond"></typeparam>
        /// <typeparam name="TReturn"></typeparam>
        /// <param name="sqlText"></param>
        /// <param name="cmdType"></param>
        /// <param name="dictParams"></param>
        /// <param name="func"></param>
        /// <param name="isUseTrans"></param>
        /// <returns></returns>
        IEnumerable<TReturn> QueryMultiple<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(string sqlText, CommandType cmdType, IDictionary<string, object> dictParams, Func<IEnumerable<TFirst>, IEnumerable<TSecond>, IEnumerable<TThird>, IEnumerable<TFourth>, IEnumerable<TFifth>, IEnumerable<TReturn>> func, bool isUseTrans);
        /// <summary>
        /// Test Connection
        /// </summary>
        /// <returns></returns>
        bool TestConnection();

        #region C# 8.0 返回多个结果集
        /// <summary>
        /// 返回结果集和数量 专用于分页
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sqlText"></param>
        /// <param name="cmdType"></param>
        /// <param name="dictParams"></param>
        /// <returns></returns>
        (IEnumerable<T>, int) QueryMultipleByPage<T>(string sqlText, CommandType cmdType, IDictionary<string, object> dictParams);

        /// <summary>
        /// 返回2个结果集
        /// </summary>
        /// <typeparam name="TFirst"></typeparam>
        /// <typeparam name="TSecond"></typeparam>
        /// <param name="sqlText"></param>
        /// <param name="cmdType"></param>
        /// <param name="dictParams"></param>
        /// <returns></returns>
        (IEnumerable<TFirst>, IEnumerable<TSecond>) QueryMultiple<TFirst, TSecond>(string sqlText, CommandType cmdType, IDictionary<string, object> dictParams);

        /// <summary>
        /// 返回3个结果集
        /// </summary>
        /// <typeparam name="TFirst"></typeparam>
        /// <typeparam name="TSecond"></typeparam>
        /// <typeparam name="TThird"></typeparam>
        /// <param name="sqlText"></param>
        /// <param name="cmdType"></param>
        /// <param name="dictParams"></param>
        /// <returns></returns>
        (IEnumerable<TFirst>, IEnumerable<TSecond>, IEnumerable<TThird>) QueryMultiple<TFirst, TSecond, TThird>(string sqlText, CommandType cmdType, IDictionary<string, object> dictParams);

        /// <summary>
        /// 返回4个结果集
        /// </summary>
        /// <typeparam name="TFirst"></typeparam>
        /// <typeparam name="TSecond"></typeparam>
        /// <typeparam name="TThird"></typeparam>
        /// <typeparam name="TFourth"></typeparam>
        /// <param name="sqlText"></param>
        /// <param name="cmdType"></param>
        /// <param name="dictParams"></param>
        /// <returns></returns>
        (IEnumerable<TFirst>, IEnumerable<TSecond>, IEnumerable<TThird>, IEnumerable<TFourth>) QueryMultiple<TFirst, TSecond, TThird, TFourth>(string sqlText, CommandType cmdType, IDictionary<string, object> dictParams);


        /// <summary>
        /// 返回5个结果集
        /// </summary>
        /// <typeparam name="TFirst"></typeparam>
        /// <typeparam name="TSecond"></typeparam>
        /// <typeparam name="TThird"></typeparam>
        /// <typeparam name="TFourth"></typeparam>
        /// <typeparam name="TFifth"></typeparam>
        /// <param name="sqlText"></param>
        /// <param name="cmdType"></param>
        /// <param name="dictParams"></param>
        /// <returns></returns>
        (IEnumerable<TFirst>, IEnumerable<TSecond>, IEnumerable<TThird>, IEnumerable<TFourth>, IEnumerable<TFifth>) QueryMultiple<TFirst, TSecond, TThird, TFourth, TFifth>(string sqlText, CommandType cmdType, IDictionary<string, object> dictParams);

        #endregion C# 8.0 返回多个结果集

    }
}
