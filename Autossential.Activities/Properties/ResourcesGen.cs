// ################################
// THIS FILE IS AUTO-GENERATE BY T4
// ################################

namespace Autossential.Activities.Properties
{
    using System.Resources;   
    

    public partial class Resources 
    {
        public static System.Globalization.CultureInfo Culture { get; set; }

        private static object _internalSyncObject;
        
        /// <summary>
        /// Thread safe lock object used by this class.
        /// </summary>
        public static object InternalSyncObject
        {
            get
            {
                if (_internalSyncObject is null)
                    System.Threading.Interlocked.CompareExchange(ref _internalSyncObject, new object(), null);
                
                return _internalSyncObject;
            }
        }
        private static ResourceManager _resourceManager;

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static ResourceManager ResourceManager
        {
            get
            {
                if (_resourceManager is null)
                {
                    System.Threading.Monitor.Enter(InternalSyncObject);

                    try
                    {
                        if (_resourceManager is null)
                            System.Threading.Interlocked.Exchange(ref _resourceManager, new ResourceManager("Autossential.Activities.Properties.Resources", typeof(Resources).Assembly));
                    }
                    finally
                    {
                        System.Threading.Monitor.Exit(InternalSyncObject);
                    }
                }
                return _resourceManager;
            }
        }

        // ####### FORMATTERS ###############################################
        
        
        /// <summary>
        /// Looks up a localized string similar to 'Please provide a value for {0}.'.
        /// </summary>
        /// <param name="arg0">An object (0) to format.</param>
        /// <returns>A copy of format string in which the format items have been replaced by the String equivalent of the corresponding instances of Object in arguments.</returns>
        public static string Validation_ValueErrorFormat(object arg0)
        {
            return string.Format(Culture, Validation_ValueError, arg0);
        }

        /// <summary>
        /// Looks up a localized string similar to 'Cannot be used outside of {0} activity.'.
        /// </summary>
        /// <param name="arg0">An object (0) to format.</param>
        /// <returns>A copy of format string in which the format items have been replaced by the String equivalent of the corresponding instances of Object in arguments.</returns>
        public static string Validation_ScopeErrorFormat(object arg0)
        {
            return string.Format(Culture, Validation_ScopeError, arg0);
        }

        /// <summary>
        /// Looks up a localized string similar to 'Please provide a value of type {0} for {1}.'.
        /// </summary>
        /// <param name="arg0">An object (0) to format.</param>
        /// <param name="arg1">An object (1) to format.</param>
        /// <returns>A copy of format string in which the format items have been replaced by the String equivalent of the corresponding instances of Object in arguments.</returns>
        public static string Validation_TypeErrorFormat(object arg0, object arg1)
        {
            return string.Format(Culture, Validation_TypeError, arg0, arg1);
        }

        /// <summary>
        /// Looks up a localized string similar to 'The accepted value range is between {0} and {1}. The value will be reseted to its nearest limit.'.
        /// </summary>
        /// <param name="arg0">An object (0) to format.</param>
        /// <param name="arg1">An object (1) to format.</param>
        /// <returns>A copy of format string in which the format items have been replaced by the String equivalent of the corresponding instances of Object in arguments.</returns>
        public static string WaitFile_ErrorMsg_IntervalRangeFormat(object arg0, object arg1)
        {
            return string.Format(Culture, WaitFile_ErrorMsg_IntervalRange, arg0, arg1);
        }
   

        // ####### GETTERS ##################################################

        
        /// <summary>
        /// Looks up a localized string similar to 'The input Dictionary.'.
        /// </summary>
        public static string DictionaryToDataTable_InputDictionary_Description => ResourceManager.GetString("DictionaryToDataTable_InputDictionary_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The encrypted DataTable.'.
        /// </summary>
        public static string EncryptDataTable_OutputDataTable_Description => ResourceManager.GetString("EncryptDataTable_OutputDataTable_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Encrypt DataTable'.
        /// </summary>
        public static string EncryptDataTable_DisplayName => ResourceManager.GetString("EncryptDataTable_DisplayName", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The expression to be evaluated.'.
        /// </summary>
        public static string CheckPoint_Expression_Description => ResourceManager.GetString("CheckPoint_Expression_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The encoding used to interpret the data and key.'.
        /// </summary>
        public static string DecryptDataTable_TextEncoding_Description => ResourceManager.GetString("DecryptDataTable_TextEncoding_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Increments the value of a variable by the specified increment value.'.
        /// </summary>
        public static string Increment_Description => ResourceManager.GetString("Increment_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Add Range To Collection'.
        /// </summary>
        public static string AddRangeToCollection_DisplayName => ResourceManager.GetString("AddRangeToCollection_DisplayName", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Decrypt DataTable'.
        /// </summary>
        public static string DecryptDataTable_DisplayName => ResourceManager.GetString("DecryptDataTable_DisplayName", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Options (Custom Mode)'.
        /// </summary>
        public static string RemoveEmptyRows_CustomOptions_Category => ResourceManager.GetString("RemoveEmptyRows_CustomOptions_Category", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The DataTable.'.
        /// </summary>
        public static string DataTableToText_DataTable_Description => ResourceManager.GetString("DataTableToText_DataTable_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The DataTable to remove duplicated rows.'.
        /// </summary>
        public static string RemoveDuplicateRows_InputDataTable_Description => ResourceManager.GetString("RemoveDuplicateRows_InputDataTable_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The result of the evaluation.'.
        /// </summary>
        public static string IsTrue_Result_Description => ResourceManager.GetString("IsTrue_Result_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Returns the number of entries (files and folders) from a Zip archive.'.
        /// </summary>
        public static string ZipEntriesCount_Description => ResourceManager.GetString("ZipEntriesCount_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Please provide an output variable for at least one of the available options.'.
        /// </summary>
        public static string ZipEntriesCount_ErrorMsg_OutputMissing => ResourceManager.GetString("ZipEntriesCount_ErrorMsg_OutputMissing", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The encoding used to interpret the text and key.'.
        /// </summary>
        public static string DecryptText_TextEncoding_Description => ResourceManager.GetString("DecryptText_TextEncoding_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The resulting DataRow from the aggregation.'.
        /// </summary>
        public static string Aggregate_Result_Description => ResourceManager.GetString("Aggregate_Result_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Please provide a value for {0}.'.
        /// </summary>
        public static string Validation_ValueError => ResourceManager.GetString("Validation_ValueError", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Converts a DataRow to Dictionary.'.
        /// </summary>
        public static string DataRowToDictionary_Description => ResourceManager.GetString("DataRowToDictionary_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Compress files into a zip archive.'.
        /// </summary>
        public static string Zip_Description => ResourceManager.GetString("Zip_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to '(Optional) Returns the information about the file.'.
        /// </summary>
        public static string WaitFile_FileInfo_Description => ResourceManager.GetString("WaitFile_FileInfo_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The output Dictionary.'.
        /// </summary>
        public static string DataRowToDictionary_OutputDictionary_Description => ResourceManager.GetString("DataRowToDictionary_OutputDictionary_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Check Point'.
        /// </summary>
        public static string CheckPoint_DisplayName => ResourceManager.GetString("CheckPoint_DisplayName", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Deletes only the files with last write time till this reference date. Default is DateTime.Now.'.
        /// </summary>
        public static string CleanUpFolder_LastWriteTime_Description => ResourceManager.GetString("CleanUpFolder_LastWriteTime_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The number of iterations to be used in operation. The default and minimum recommended is 1000.'.
        /// </summary>
        public static string DecryptDataTable_Iterations_Description => ResourceManager.GetString("DecryptDataTable_Iterations_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Performs a boolean evaluation of a value or expression.'.
        /// </summary>
        public static string IsTrue_Description => ResourceManager.GetString("IsTrue_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The items to be added to the collection.'.
        /// </summary>
        public static string AddRangeToCollection_Items_Description => ResourceManager.GetString("AddRangeToCollection_Items_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The encrypt algorithm to be used by this activity.'.
        /// </summary>
        public static string EncryptDataTable_Algorithm_Description => ResourceManager.GetString("EncryptDataTable_Algorithm_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The path of the file(s) or folder(s) that will be compressed. Can be a string or a collection of strings.'.
        /// </summary>
        public static string Zip_ToCompress_Description => ResourceManager.GetString("Zip_ToCompress_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Replaces an empty column name by the value of this property.'.
        /// </summary>
        public static string PromoteHeaders_EmptyColumnName_Description => ResourceManager.GetString("PromoteHeaders_EmptyColumnName_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Returns an enumerable collection of full file names that match a search pattern (or collection of patterns) and enumeration options in a specified path (or collection of paths).'.
        /// </summary>
        public static string EnumerateFiles_Description => ResourceManager.GetString("EnumerateFiles_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Returns the number of file entries in the zip archive.'.
        /// </summary>
        public static string ZipEntriesCount_FilesCount_Description => ResourceManager.GetString("ZipEntriesCount_FilesCount_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The exception that will be thrown if the expression is not true.'.
        /// </summary>
        public static string CheckPoint_Exception_Description => ResourceManager.GetString("CheckPoint_Exception_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Excludes from the enumeration the files with any of the specified attributes.'.
        /// </summary>
        public static string EnumerateFiles_Exclusions_Description => ResourceManager.GetString("EnumerateFiles_Exclusions_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Cannot be used outside of {0} activity.'.
        /// </summary>
        public static string Validation_ScopeError => ResourceManager.GetString("Validation_ScopeError", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Specifies the amount of time in milliseconds to wait for the activity to run before an error is thrown. The default value is 30000 (30s).'.
        /// </summary>
        public static string Common_Timeout => ResourceManager.GetString("Common_Timeout", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'When true, it avoids the "column name already belongs to DataTable" error by adding a numeric suffix to it.'.
        /// </summary>
        public static string PromoteHeaders_AutoRename_Description => ResourceManager.GetString("PromoteHeaders_AutoRename_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Uses parallel processing to scan through the DataTable and encrypt the data. Although this can drastically increase the processing speed, the rows in the resulting DataTable may have its order changed. Combine it with Sort property to reorder the DataTable when necessary.'.
        /// </summary>
        public static string EncryptDataTable_ParallelProcessing_Description => ResourceManager.GetString("EncryptDataTable_ParallelProcessing_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'An object containing the number of files deleted, folders deleted and total deleted.'.
        /// </summary>
        public static string CleanUpFolder_Result_Description => ResourceManager.GetString("CleanUpFolder_Result_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The column indexes or column names to apply the aggregation. If not specified, the aggregation will be applied in all possible columns.'.
        /// </summary>
        public static string Aggregate_Columns_Description => ResourceManager.GetString("Aggregate_Columns_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Encrypts a text using the specified algorithm and key.'.
        /// </summary>
        public static string EncryptText_Description => ResourceManager.GetString("EncryptText_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'If set, continue executing the remaining activities even if the current activity has failed.'.
        /// </summary>
        public static string Common_ContinueOnError => ResourceManager.GetString("Common_ContinueOnError", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The base64 string representation of the encrypted text.'.
        /// </summary>
        public static string EncryptText_Result_Description => ResourceManager.GetString("EncryptText_Result_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Skips the current iteration in an Iterate activity and proceeds the execution with the next iteration.'.
        /// </summary>
        public static string Next_Description => ResourceManager.GetString("Next_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'A container that allows you to run a set of activities over a different culture.'.
        /// </summary>
        public static string CultureScope_Description => ResourceManager.GetString("CultureScope_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Determines the type of each value extracted from the data column.'.
        /// </summary>
        public static string ExtractDataColumnValues_TypeArgument_Description => ResourceManager.GetString("ExtractDataColumnValues_TypeArgument_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Clean Up Folder'.
        /// </summary>
        public static string CleanUpFolder_DisplayName => ResourceManager.GetString("CleanUpFolder_DisplayName", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Remove Data Columns'.
        /// </summary>
        public static string RemoveDataColumns_DisplayName => ResourceManager.GetString("RemoveDataColumns_DisplayName", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Determines the evaluation condition for the specified columns where (And) checks if all columns are empty and (Or) checks if any of the columns are empty.'.
        /// </summary>
        public static string RemoveEmptyRows_Operator_Description => ResourceManager.GetString("RemoveEmptyRows_Operator_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The number of iterations to be used in operation. The default and minimum recommended is 1000.'.
        /// </summary>
        public static string EncryptDataTable_Iterations_Description => ResourceManager.GetString("EncryptDataTable_Iterations_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Zip Entries Count'.
        /// </summary>
        public static string ZipEntriesCount_DisplayName => ResourceManager.GetString("ZipEntriesCount_DisplayName", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Iterates the activity execution for the specified number of times.'.
        /// </summary>
        public static string Iterate_Description => ResourceManager.GetString("Iterate_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The encoding to use when writing entry names in this archive. Specify a value for this parameter only when an encoding is required for interoperability with zip archive tools and libraries that do not support UTF-8 encoding for entry names.'.
        /// </summary>
        public static string Zip_TextEncoding_Description => ResourceManager.GetString("Zip_TextEncoding_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Provides a set of methods and properties that you can use to accurately measure elapsed time.'.
        /// </summary>
        public static string Stopwatch_Description => ResourceManager.GetString("Stopwatch_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Decrements the value of a variable by the specified decrement value.'.
        /// </summary>
        public static string Decrement_Description => ResourceManager.GetString("Decrement_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Removes the duplicate rows from a DataTable keeping only the first occurrence. Allows specify a limited number of columns for this comparison.'.
        /// </summary>
        public static string RemoveDuplicateRows_Description => ResourceManager.GetString("RemoveDuplicateRows_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Uses parallel processing to scan through the DataTable and decrypt the data. Although this can drastically increase the processing speed, the rows in the resulting DataTable may have its order changed. Combine it with Sort property to reorder the DataTable when necessary.'.
        /// </summary>
        public static string DecryptDataTable_ParallelProcessing_Description => ResourceManager.GetString("DecryptDataTable_ParallelProcessing_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Iterations must have a value greater than zero.'.
        /// </summary>
        public static string Iterate_ErrorMsg_IterationsMinValue => ResourceManager.GetString("Iterate_ErrorMsg_IterationsMinValue", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The data table which the aggregate function will be applied.'.
        /// </summary>
        public static string Aggregate_InputDataTable_Description => ResourceManager.GetString("Aggregate_InputDataTable_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Is True'.
        /// </summary>
        public static string IsTrue_DisplayName => ResourceManager.GetString("IsTrue_DisplayName", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'DataTable To Text'.
        /// </summary>
        public static string DataTableToText_DisplayName => ResourceManager.GetString("DataTableToText_DisplayName", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The column names or column indexes to be analyzed on duplicate rows comparison. Can be either a collection of string or int.'.
        /// </summary>
        public static string RemoveDuplicateRows_Columns_Description => ResourceManager.GetString("RemoveDuplicateRows_Columns_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The maximum timeout to wait in milliseconds.'.
        /// </summary>
        public static string WaitFile_Timeout_Description => ResourceManager.GetString("WaitFile_Timeout_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Aggregates the DataTable data by the specified function resulting in a DataRow, product of this aggregation.'.
        /// </summary>
        public static string Aggregate_Description => ResourceManager.GetString("Aggregate_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The column name or index where the values will be extracted from.'.
        /// </summary>
        public static string ExtractDataColumnValues_Column_Description => ResourceManager.GetString("ExtractDataColumnValues_Column_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Returns an array with all values of a respective data column.'.
        /// </summary>
        public static string ExtractDataColumnValues_Description => ResourceManager.GetString("ExtractDataColumnValues_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'DataRow To Dictionary'.
        /// </summary>
        public static string DataRowToDictionary_DisplayName => ResourceManager.GetString("DataRowToDictionary_DisplayName", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Checks if a given expression is true, if not, thrown the specified exception.'.
        /// </summary>
        public static string CheckPoint_Description => ResourceManager.GetString("CheckPoint_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Enumerate Files'.
        /// </summary>
        public static string EnumerateFiles_DisplayName => ResourceManager.GetString("EnumerateFiles_DisplayName", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Removes the specified columns from a DataTable'.
        /// </summary>
        public static string RemoveDataColumns_Description => ResourceManager.GetString("RemoveDataColumns_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Waits until the file exists.'.
        /// </summary>
        public static string WaitFile_WaitForExist_Description => ResourceManager.GetString("WaitFile_WaitForExist_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Reference'.
        /// </summary>
        public static string InputOutput_Category => ResourceManager.GetString("InputOutput_Category", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The number of iterations to be used in operation. The default and minimum recommended is 1000.'.
        /// </summary>
        public static string EncryptText_Iterations_Description => ResourceManager.GetString("EncryptText_Iterations_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'When true, overwrites an existing file that has the same name as the destination file.'.
        /// </summary>
        public static string Unzip_Overwrite_Description => ResourceManager.GetString("Unzip_Overwrite_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The string representation of the DataTable.'.
        /// </summary>
        public static string DataTableToText_Result_Description => ResourceManager.GetString("DataTableToText_Result_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Common'.
        /// </summary>
        public static string Common_Category => ResourceManager.GetString("Common_Category", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The zero-based iteration index.'.
        /// </summary>
        public static string Iterate_Index_Description => ResourceManager.GetString("Iterate_Index_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The number of iterations to be used in operation. The default and minimum recommended is 1000.'.
        /// </summary>
        public static string DecryptText_Iterations_Description => ResourceManager.GetString("DecryptText_Iterations_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The path of the zip archive.'.
        /// </summary>
        public static string Zip_ZipFilePath_Description => ResourceManager.GetString("Zip_ZipFilePath_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The decrypt algorithm to be used by this activity.'.
        /// </summary>
        public static string DecryptText_Algorithm_Description => ResourceManager.GetString("DecryptText_Algorithm_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Promote Headers'.
        /// </summary>
        public static string PromoteHeaders_DisplayName => ResourceManager.GetString("PromoteHeaders_DisplayName", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Returns a string representation of a datatable on the specified text format (HTML, JSON or XML).'.
        /// </summary>
        public static string DataTableToText_Description => ResourceManager.GetString("DataTableToText_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The decrement value cannot be smaller than 1.'.
        /// </summary>
        public static string Decrement_ErrorMsg_MinValue => ResourceManager.GetString("Decrement_ErrorMsg_MinValue", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The encrypt algorithm to be used by this activity.'.
        /// </summary>
        public static string EncryptText_Algorithm_Description => ResourceManager.GetString("EncryptText_Algorithm_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Dictionary To DataTable'.
        /// </summary>
        public static string DictionaryToDataTable_DisplayName => ResourceManager.GetString("DictionaryToDataTable_DisplayName", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Deletes all files and folders from a specified folder.'.
        /// </summary>
        public static string CleanUpFolder_Description => ResourceManager.GetString("CleanUpFolder_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The increment value cannot be smaller than 1.'.
        /// </summary>
        public static string Increment_ErrorMsg_MinValue => ResourceManager.GetString("Increment_ErrorMsg_MinValue", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The input DataTable.'.
        /// </summary>
        public static string PromoteHeaders_InputDataTable_Description => ResourceManager.GetString("PromoteHeaders_InputDataTable_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The column names or column indexes to be removed. Can be either a collection of string or int.'.
        /// </summary>
        public static string RemoveDataColumns_Columns_Description => ResourceManager.GetString("RemoveDataColumns_Columns_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Condition which determines if the activity will be evaluated. If empty it assumes True.'.
        /// </summary>
        public static string Exit_Condition_Description => ResourceManager.GetString("Exit_Condition_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Output'.
        /// </summary>
        public static string Output_Category => ResourceManager.GetString("Output_Category", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The encoding used to interpret the text and key.'.
        /// </summary>
        public static string EncryptText_TextEncoding_Description => ResourceManager.GetString("EncryptText_TextEncoding_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The input DataTable to be transposed.'.
        /// </summary>
        public static string TransposeData_InputDataTable_Description => ResourceManager.GetString("TransposeData_InputDataTable_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Its a wrapper that when combined with Exit Activity, interrupts the children execution flow exiting the Container beforehand.'.
        /// </summary>
        public static string Container_Description => ResourceManager.GetString("Container_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Remove Empty Rows'.
        /// </summary>
        public static string RemoveEmptyRows_DisplayName => ResourceManager.GetString("RemoveEmptyRows_DisplayName", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Transpose Data'.
        /// </summary>
        public static string TransposeData_DisplayName => ResourceManager.GetString("TransposeData_DisplayName", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The input DataRow.'.
        /// </summary>
        public static string DataRowToDictionary_InputDataRow_Description => ResourceManager.GetString("DataRowToDictionary_InputDataRow_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The column indexes or column names to be encrypted.'.
        /// </summary>
        public static string EncryptDataTable_Columns_Description => ResourceManager.GetString("EncryptDataTable_Columns_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'When true, renames the entry if the entry's name already exists in zip archive. It uses the pattern <entry>.<counter>.<extension>.'.
        /// </summary>
        public static string Zip_AutoRenaming_Description => ResourceManager.GetString("Zip_AutoRenaming_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The desired culture, eg.: en-US, pt-BR, jp-JP, etc.'.
        /// </summary>
        public static string CultureScope_CultureName_Description => ResourceManager.GetString("CultureScope_CultureName_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Remove Duplicate Rows'.
        /// </summary>
        public static string RemoveDuplicateRows_DisplayName => ResourceManager.GetString("RemoveDuplicateRows_DisplayName", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The text to be encrypted.'.
        /// </summary>
        public static string EncryptText_Text_Description => ResourceManager.GetString("EncryptText_Text_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The specified file path does not exists.'.
        /// </summary>
        public static string WaitFile_ErrorMsg_FilePathDoesNotExists => ResourceManager.GetString("WaitFile_ErrorMsg_FilePathDoesNotExists", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The DataTable to be decrypted.'.
        /// </summary>
        public static string DecryptDataTable_InputDataTable_Description => ResourceManager.GetString("DecryptDataTable_InputDataTable_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Determines which method must be invoked by activity.'.
        /// </summary>
        public static string Stopwatch_Method_Description => ResourceManager.GetString("Stopwatch_Method_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Returns the amount of files added to zip archive.'.
        /// </summary>
        public static string Zip_FilesCount_Description => ResourceManager.GetString("Zip_FilesCount_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The decrypted text.'.
        /// </summary>
        public static string DecryptText_Result_Description => ResourceManager.GetString("DecryptText_Result_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Returns the information about the file.'.
        /// </summary>
        public static string WaitDynamicFile_FileInfo_Description => ResourceManager.GetString("WaitDynamicFile_FileInfo_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Adds a set of items to the specified collection.'.
        /// </summary>
        public static string AddRangeToCollection_Description => ResourceManager.GetString("AddRangeToCollection_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Reverses the order of the output index.'.
        /// </summary>
        public static string Iterate_Reverse_Description => ResourceManager.GetString("Iterate_Reverse_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The output DataTable.'.
        /// </summary>
        public static string DictionaryToDataTable_OutputDataTable_Description => ResourceManager.GetString("DictionaryToDataTable_OutputDataTable_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Sets the sort column or columns, and sort order for the output DataTable. The value must be a string that contains the column name followed by "ASC" (ascending) or "DESC" (descending). Columns are sorted ascending by default. Multiple columns can be separated by commas.'.
        /// </summary>
        public static string EncryptDataTable_Sort_Description => ResourceManager.GetString("EncryptDataTable_Sort_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Specifies the amount of time (in milliseconds) for the file re-check. Any values out of the range of 100-30000 milliseconds is reseted to its nearest limit. The default value is 500.'.
        /// </summary>
        public static string WaitDynamicFile_Interval_Description => ResourceManager.GetString("WaitDynamicFile_Interval_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'One of the enumeration values that indicates whether to emphasize speed or compression.'.
        /// </summary>
        public static string Zip_CompressionLevel_Description => ResourceManager.GetString("Zip_CompressionLevel_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The Items property value cannot be null.'.
        /// </summary>
        public static string AddRangeToCollection_ErrorMsg_ItemsNull => ResourceManager.GetString("AddRangeToCollection_ErrorMsg_ItemsNull", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The search string to match against the names of files in path. This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn't support regular expressions. It also supports a collection of strings. Default value is "*.*".'.
        /// </summary>
        public static string WaitDynamicFile_SearchPattern_Description => ResourceManager.GetString("WaitDynamicFile_SearchPattern_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The DataTable to be encrypted.'.
        /// </summary>
        public static string EncryptDataTable_InputDataTable_Description => ResourceManager.GetString("EncryptDataTable_InputDataTable_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Determines if the left empty folders after files deletion must also be deleted. Default is true.'.
        /// </summary>
        public static string CleanUpFolder_DeleteEmptyFolders_Description => ResourceManager.GetString("CleanUpFolder_DeleteEmptyFolders_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Extracting Zip entry would have resulted in a file outside the specified destination directory.'.
        /// </summary>
        public static string Unzip_ErrorMsg_OutsideDir => ResourceManager.GetString("Unzip_ErrorMsg_OutsideDir", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The decrypt algorithm to be used by this activity.'.
        /// </summary>
        public static string DecryptDataTable_Algorithm_Description => ResourceManager.GetString("DecryptDataTable_Algorithm_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Decrypts the data of a DataTable using the specified algorithm and key.'.
        /// </summary>
        public static string DecryptDataTable_Description => ResourceManager.GetString("DecryptDataTable_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Determines when a row should be removed. (All) means that all columns must be empty to remove the row. (Any) for any column empty and (Custom) for the user defined rules.'.
        /// </summary>
        public static string RemoveEmptyRows_Mode_Description => ResourceManager.GetString("RemoveEmptyRows_Mode_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Sets the sort column or columns, and sort order for the output DataTable. The value must be a string that contains the column name followed by "ASC" (ascending) or "DESC" (descending). Columns are sorted ascending by default. Multiple columns can be separated by commas.'.
        /// </summary>
        public static string DecryptDataTable_Sort_Description => ResourceManager.GetString("DecryptDataTable_Sort_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The search string to match against the names of files in path. This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn't support regular expressions. It also supports a collection of strings. Default value is "*.*".'.
        /// </summary>
        public static string CleanUpFolder_SearchPattern_Description => ResourceManager.GetString("CleanUpFolder_SearchPattern_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'A variable that represents the instance of System.Diagnostics.Stopwatch class.'.
        /// </summary>
        public static string Stopwatch_StopwatchObj_Description => ResourceManager.GetString("Stopwatch_StopwatchObj_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Zip entry name ends in directory separator character but contains data.'.
        /// </summary>
        public static string Unzip_ErrorMsg_DirNameWithData => ResourceManager.GetString("Unzip_ErrorMsg_DirNameWithData", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'An enumerable collection of the full names (including paths) for the files in the directory specified by path and that match the specified search pattern and option.'.
        /// </summary>
        public static string EnumerateFiles_Result_Description => ResourceManager.GetString("EnumerateFiles_Result_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The value to be use in case of the extract value cannot be converted to the specified type.'.
        /// </summary>
        public static string ExtractDataColumnValues_DefaultValue_DisplayName => ResourceManager.GetString("ExtractDataColumnValues_DefaultValue_DisplayName", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Stopwatch'.
        /// </summary>
        public static string Stopwatch_StopwatchObj_DisplayName => ResourceManager.GetString("Stopwatch_StopwatchObj_DisplayName", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The input DataTable.'.
        /// </summary>
        public static string RemoveEmptyRows_InputDataTable_Description => ResourceManager.GetString("RemoveEmptyRows_InputDataTable_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The collection that will receive the new items.'.
        /// </summary>
        public static string AddRangeToCollection_Collection_Description => ResourceManager.GetString("AddRangeToCollection_Collection_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Specifies the amount of time (in milliseconds) for the file re-check. Any values out of the range of 100-30000 milliseconds is reseted to its nearest limit. The default value is 500.'.
        /// </summary>
        public static string WaitFile_Interval_Description => ResourceManager.GetString("WaitFile_Interval_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Encrypt Text'.
        /// </summary>
        public static string EncryptText_DisplayName => ResourceManager.GetString("EncryptText_DisplayName", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The path of the zip archive.'.
        /// </summary>
        public static string ZipEntriesCount_ZipFilePath_Description => ResourceManager.GetString("ZipEntriesCount_ZipFilePath_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'DataTable'.
        /// </summary>
        public static string Aggregate_InputDataTable_DisplayName => ResourceManager.GetString("Aggregate_InputDataTable_DisplayName", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The decrement value.'.
        /// </summary>
        public static string Decrement_Value_Description => ResourceManager.GetString("Decrement_Value_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Returns a data row detached from the data table.'.
        /// </summary>
        public static string Aggregate_Detached_Description => ResourceManager.GetString("Aggregate_Detached_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Removes the empty rows from a DataTable.'.
        /// </summary>
        public static string RemoveEmptyRows_Description => ResourceManager.GetString("RemoveEmptyRows_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The path to the folder where files will be extracted.'.
        /// </summary>
        public static string Unzip_ExtractTo_Description => ResourceManager.GetString("Unzip_ExtractTo_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The column names to be encrypted.'.
        /// </summary>
        public static string EncryptDataTable_ColumnNames_Description => ResourceManager.GetString("EncryptDataTable_ColumnNames_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The output DataTable.'.
        /// </summary>
        public static string PromoteHeaders_OutputDataTable_Description => ResourceManager.GetString("PromoteHeaders_OutputDataTable_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The date format to be used on the string representation for DateTime column types.'.
        /// </summary>
        public static string DataTableToText_DateTimeFormat_Description => ResourceManager.GetString("DataTableToText_DateTimeFormat_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The DataTable object from which the columns is to be removed.'.
        /// </summary>
        public static string RemoveDataColumns_DataTable_Description => ResourceManager.GetString("RemoveDataColumns_DataTable_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'A collection of key/value pairs that provide additional user-defined information about the exception.'.
        /// </summary>
        public static string CheckPoint_Data_Description => ResourceManager.GetString("CheckPoint_Data_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The maximum timeout to wait in milliseconds.'.
        /// </summary>
        public static string WaitDynamicFile_Timeout_Description => ResourceManager.GetString("WaitDynamicFile_Timeout_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Determines from what creation time the file should be considered.'.
        /// </summary>
        public static string WaitDynamicFile_AfterCreationTime_Description => ResourceManager.GetString("WaitDynamicFile_AfterCreationTime_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The variable to be incremented.'.
        /// </summary>
        public static string Increment_Variable_Description => ResourceManager.GetString("Increment_Variable_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Please provide a value of type {0} for {1}.'.
        /// </summary>
        public static string Validation_TypeError => ResourceManager.GetString("Validation_TypeError", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Transposes a DataTable by swapping its rows and columns so that rows become columns and columns become rows.'.
        /// </summary>
        public static string TransposeData_Description => ResourceManager.GetString("TransposeData_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The compressed file.'.
        /// </summary>
        public static string Unzip_ZipFilePath_Description => ResourceManager.GetString("Unzip_ZipFilePath_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Wait Dynamic File'.
        /// </summary>
        public static string WaitDynamicFile_DisplayName => ResourceManager.GetString("WaitDynamicFile_DisplayName", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Waits until an unknown file be available by monitoring a specified folder.'.
        /// </summary>
        public static string WaitDynamicFile_Description => ResourceManager.GetString("WaitDynamicFile_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Wait File'.
        /// </summary>
        public static string WaitFile_DisplayName => ResourceManager.GetString("WaitFile_DisplayName", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Decrypt Text'.
        /// </summary>
        public static string DecryptText_DisplayName => ResourceManager.GetString("DecryptText_DisplayName", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Decompress files from a zip archive.'.
        /// </summary>
        public static string Unzip_Description => ResourceManager.GetString("Unzip_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The number of entries (files and folders) in the zip archive.'.
        /// </summary>
        public static string ZipEntriesCount_EntriesCount_Description => ResourceManager.GetString("ZipEntriesCount_EntriesCount_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Options'.
        /// </summary>
        public static string Options_Category => ResourceManager.GetString("Options_Category", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Input'.
        /// </summary>
        public static string Input_Category => ResourceManager.GetString("Input_Category", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The output DataTable resulting of the transpose.'.
        /// </summary>
        public static string TransposeData_OutputDataTable_Description => ResourceManager.GetString("TransposeData_OutputDataTable_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Encrypts the data of a DataTable using the specified algorithm and key.'.
        /// </summary>
        public static string EncryptDataTable_Description => ResourceManager.GetString("EncryptDataTable_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Decrypts the text using the specified algorithm and key.'.
        /// </summary>
        public static string DecryptText_Description => ResourceManager.GetString("DecryptText_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Extract Data Column Values'.
        /// </summary>
        public static string ExtractDataColumnValues_DisplayName => ResourceManager.GetString("ExtractDataColumnValues_DisplayName", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The directory to be monitored.'.
        /// </summary>
        public static string WaitDynamicFile_DirectoryPath_Description => ResourceManager.GetString("WaitDynamicFile_DirectoryPath_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Returns the number of folder entries in the zip archive.'.
        /// </summary>
        public static string ZipEntriesCount_FoldersCount_Description => ResourceManager.GetString("ZipEntriesCount_FoldersCount_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The output DataTable.'.
        /// </summary>
        public static string RemoveEmptyRows_OutputDataTable_Description => ResourceManager.GetString("RemoveEmptyRows_OutputDataTable_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Promotes the first row of values to new column headers.'.
        /// </summary>
        public static string PromoteHeaders_Description => ResourceManager.GetString("PromoteHeaders_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The column indexes or column names to be decrypted.'.
        /// </summary>
        public static string DecryptDataTable_Columns_Description => ResourceManager.GetString("DecryptDataTable_Columns_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The encoding used to interpret the data and key.'.
        /// </summary>
        public static string EncryptDataTable_TextEncoding_Description => ResourceManager.GetString("EncryptDataTable_TextEncoding_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Converts a Dictionary to DataTable.'.
        /// </summary>
        public static string DictionaryToDataTable_Description => ResourceManager.GetString("DictionaryToDataTable_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The data table where the values will be extracted from.'.
        /// </summary>
        public static string ExtractDataColumnValues_DataTable_Description => ResourceManager.GetString("ExtractDataColumnValues_DataTable_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The folder path to be cleaned up.'.
        /// </summary>
        public static string CleanUpFolder_Folder_Description => ResourceManager.GetString("CleanUpFolder_Folder_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The variable to decrement.'.
        /// </summary>
        public static string Decrement_Variable_Description => ResourceManager.GetString("Decrement_Variable_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The column indexes or column names to verify.'.
        /// </summary>
        public static string RemoveEmptyRows_Columns_Description => ResourceManager.GetString("RemoveEmptyRows_Columns_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The relative or absolute path (or collection of paths) to the directory (or directories) to search.'.
        /// </summary>
        public static string EnumerateFiles_Path_Description => ResourceManager.GetString("EnumerateFiles_Path_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The increment value.'.
        /// </summary>
        public static string Increment_Value_Description => ResourceManager.GetString("Increment_Value_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The text format.'.
        /// </summary>
        public static string DataTableToText_TextFormat_Description => ResourceManager.GetString("DataTableToText_TextFormat_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The decrypted DataTable.'.
        /// </summary>
        public static string DecryptDataTable_OutputDataTable_Description => ResourceManager.GetString("DecryptDataTable_OutputDataTable_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The number of iterations that must be run.'.
        /// </summary>
        public static string Iterate_Iterations_Description => ResourceManager.GetString("Iterate_Iterations_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The aggregate function.'.
        /// </summary>
        public static string Aggregate_Function_Description => ResourceManager.GetString("Aggregate_Function_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Exits from the Container or Iterate Activities interrupting any child executions after it.'.
        /// </summary>
        public static string Exit_Description => ResourceManager.GetString("Exit_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The accepted value range is between {0} and {1}. The value will be reseted to its nearest limit.'.
        /// </summary>
        public static string WaitFile_ErrorMsg_IntervalRange => ResourceManager.GetString("WaitFile_ErrorMsg_IntervalRange", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The output DataTable with the distinct rows.'.
        /// </summary>
        public static string RemoveDuplicateRows_OutputDataTable_Description => ResourceManager.GetString("RemoveDuplicateRows_OutputDataTable_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Culture Scope'.
        /// </summary>
        public static string CultureScope_DisplayName => ResourceManager.GetString("CultureScope_DisplayName", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The value or expression to be evaluated.'.
        /// </summary>
        public static string IsTrue_Value_Description => ResourceManager.GetString("IsTrue_Value_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The array of values extracted from the data column.'.
        /// </summary>
        public static string ExtractDataColumnValues_Result_Description => ResourceManager.GetString("ExtractDataColumnValues_Result_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The Collection property value cannot be null.'.
        /// </summary>
        public static string AddRangeToCollection_ErrorMsg_CollectionNull => ResourceManager.GetString("AddRangeToCollection_ErrorMsg_CollectionNull", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Waits until the file be available.'.
        /// </summary>
        public static string WaitFile_Description => ResourceManager.GetString("WaitFile_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The text to be decrypted.'.
        /// </summary>
        public static string DecryptText_Text_Description => ResourceManager.GetString("DecryptText_Text_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The storage path of the file.'.
        /// </summary>
        public static string WaitFile_FilePath_Description => ResourceManager.GetString("WaitFile_FilePath_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'The search string to match against the names of files in path. This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn't support regular expressions. It also supports a collection of strings. Default value is "*.*".'.
        /// </summary>
        public static string EnumerateFiles_SearchPattern_Description => ResourceManager.GetString("EnumerateFiles_SearchPattern_Description", Culture);
    

        /// <summary>
        /// Looks up a localized string similar to 'Specifies whether the search operation should include only the current directory or should include all subdirectories.'.
        /// </summary>
        public static string EnumerateFiles_SearchOption_Description => ResourceManager.GetString("EnumerateFiles_SearchOption_Description", Culture);
    
   

        // ####### RESOURCE NAMES ###########################################

        /// <summary>
        /// Contains all resource names stored in their respective constants.
        /// </summary>
        public static class ResourceNames
        {
            
            /// <summary>
            /// Stores the resource name 'DictionaryToDataTable_InputDictionary_Description'.
            /// </summary>
            public const string DictionaryToDataTable_InputDictionary_Description = "DictionaryToDataTable_InputDictionary_Description";
        

            /// <summary>
            /// Stores the resource name 'EncryptDataTable_OutputDataTable_Description'.
            /// </summary>
            public const string EncryptDataTable_OutputDataTable_Description = "EncryptDataTable_OutputDataTable_Description";
        

            /// <summary>
            /// Stores the resource name 'EncryptDataTable_DisplayName'.
            /// </summary>
            public const string EncryptDataTable_DisplayName = "EncryptDataTable_DisplayName";
        

            /// <summary>
            /// Stores the resource name 'CheckPoint_Expression_Description'.
            /// </summary>
            public const string CheckPoint_Expression_Description = "CheckPoint_Expression_Description";
        

            /// <summary>
            /// Stores the resource name 'DecryptDataTable_TextEncoding_Description'.
            /// </summary>
            public const string DecryptDataTable_TextEncoding_Description = "DecryptDataTable_TextEncoding_Description";
        

            /// <summary>
            /// Stores the resource name 'Increment_Description'.
            /// </summary>
            public const string Increment_Description = "Increment_Description";
        

            /// <summary>
            /// Stores the resource name 'AddRangeToCollection_DisplayName'.
            /// </summary>
            public const string AddRangeToCollection_DisplayName = "AddRangeToCollection_DisplayName";
        

            /// <summary>
            /// Stores the resource name 'DecryptDataTable_DisplayName'.
            /// </summary>
            public const string DecryptDataTable_DisplayName = "DecryptDataTable_DisplayName";
        

            /// <summary>
            /// Stores the resource name 'RemoveEmptyRows_CustomOptions_Category'.
            /// </summary>
            public const string RemoveEmptyRows_CustomOptions_Category = "RemoveEmptyRows_CustomOptions_Category";
        

            /// <summary>
            /// Stores the resource name 'DataTableToText_DataTable_Description'.
            /// </summary>
            public const string DataTableToText_DataTable_Description = "DataTableToText_DataTable_Description";
        

            /// <summary>
            /// Stores the resource name 'RemoveDuplicateRows_InputDataTable_Description'.
            /// </summary>
            public const string RemoveDuplicateRows_InputDataTable_Description = "RemoveDuplicateRows_InputDataTable_Description";
        

            /// <summary>
            /// Stores the resource name 'IsTrue_Result_Description'.
            /// </summary>
            public const string IsTrue_Result_Description = "IsTrue_Result_Description";
        

            /// <summary>
            /// Stores the resource name 'ZipEntriesCount_Description'.
            /// </summary>
            public const string ZipEntriesCount_Description = "ZipEntriesCount_Description";
        

            /// <summary>
            /// Stores the resource name 'ZipEntriesCount_ErrorMsg_OutputMissing'.
            /// </summary>
            public const string ZipEntriesCount_ErrorMsg_OutputMissing = "ZipEntriesCount_ErrorMsg_OutputMissing";
        

            /// <summary>
            /// Stores the resource name 'DecryptText_TextEncoding_Description'.
            /// </summary>
            public const string DecryptText_TextEncoding_Description = "DecryptText_TextEncoding_Description";
        

            /// <summary>
            /// Stores the resource name 'Aggregate_Result_Description'.
            /// </summary>
            public const string Aggregate_Result_Description = "Aggregate_Result_Description";
        

            /// <summary>
            /// Stores the resource name 'Validation_ValueError'.
            /// </summary>
            public const string Validation_ValueError = "Validation_ValueError";
        

            /// <summary>
            /// Stores the resource name 'DataRowToDictionary_Description'.
            /// </summary>
            public const string DataRowToDictionary_Description = "DataRowToDictionary_Description";
        

            /// <summary>
            /// Stores the resource name 'Zip_Description'.
            /// </summary>
            public const string Zip_Description = "Zip_Description";
        

            /// <summary>
            /// Stores the resource name 'WaitFile_FileInfo_Description'.
            /// </summary>
            public const string WaitFile_FileInfo_Description = "WaitFile_FileInfo_Description";
        

            /// <summary>
            /// Stores the resource name 'DataRowToDictionary_OutputDictionary_Description'.
            /// </summary>
            public const string DataRowToDictionary_OutputDictionary_Description = "DataRowToDictionary_OutputDictionary_Description";
        

            /// <summary>
            /// Stores the resource name 'CheckPoint_DisplayName'.
            /// </summary>
            public const string CheckPoint_DisplayName = "CheckPoint_DisplayName";
        

            /// <summary>
            /// Stores the resource name 'CleanUpFolder_LastWriteTime_Description'.
            /// </summary>
            public const string CleanUpFolder_LastWriteTime_Description = "CleanUpFolder_LastWriteTime_Description";
        

            /// <summary>
            /// Stores the resource name 'DecryptDataTable_Iterations_Description'.
            /// </summary>
            public const string DecryptDataTable_Iterations_Description = "DecryptDataTable_Iterations_Description";
        

            /// <summary>
            /// Stores the resource name 'IsTrue_Description'.
            /// </summary>
            public const string IsTrue_Description = "IsTrue_Description";
        

            /// <summary>
            /// Stores the resource name 'AddRangeToCollection_Items_Description'.
            /// </summary>
            public const string AddRangeToCollection_Items_Description = "AddRangeToCollection_Items_Description";
        

            /// <summary>
            /// Stores the resource name 'EncryptDataTable_Algorithm_Description'.
            /// </summary>
            public const string EncryptDataTable_Algorithm_Description = "EncryptDataTable_Algorithm_Description";
        

            /// <summary>
            /// Stores the resource name 'Zip_ToCompress_Description'.
            /// </summary>
            public const string Zip_ToCompress_Description = "Zip_ToCompress_Description";
        

            /// <summary>
            /// Stores the resource name 'PromoteHeaders_EmptyColumnName_Description'.
            /// </summary>
            public const string PromoteHeaders_EmptyColumnName_Description = "PromoteHeaders_EmptyColumnName_Description";
        

            /// <summary>
            /// Stores the resource name 'EnumerateFiles_Description'.
            /// </summary>
            public const string EnumerateFiles_Description = "EnumerateFiles_Description";
        

            /// <summary>
            /// Stores the resource name 'ZipEntriesCount_FilesCount_Description'.
            /// </summary>
            public const string ZipEntriesCount_FilesCount_Description = "ZipEntriesCount_FilesCount_Description";
        

            /// <summary>
            /// Stores the resource name 'CheckPoint_Exception_Description'.
            /// </summary>
            public const string CheckPoint_Exception_Description = "CheckPoint_Exception_Description";
        

            /// <summary>
            /// Stores the resource name 'EnumerateFiles_Exclusions_Description'.
            /// </summary>
            public const string EnumerateFiles_Exclusions_Description = "EnumerateFiles_Exclusions_Description";
        

            /// <summary>
            /// Stores the resource name 'Validation_ScopeError'.
            /// </summary>
            public const string Validation_ScopeError = "Validation_ScopeError";
        

            /// <summary>
            /// Stores the resource name 'Common_Timeout'.
            /// </summary>
            public const string Common_Timeout = "Common_Timeout";
        

            /// <summary>
            /// Stores the resource name 'PromoteHeaders_AutoRename_Description'.
            /// </summary>
            public const string PromoteHeaders_AutoRename_Description = "PromoteHeaders_AutoRename_Description";
        

            /// <summary>
            /// Stores the resource name 'EncryptDataTable_ParallelProcessing_Description'.
            /// </summary>
            public const string EncryptDataTable_ParallelProcessing_Description = "EncryptDataTable_ParallelProcessing_Description";
        

            /// <summary>
            /// Stores the resource name 'CleanUpFolder_Result_Description'.
            /// </summary>
            public const string CleanUpFolder_Result_Description = "CleanUpFolder_Result_Description";
        

            /// <summary>
            /// Stores the resource name 'Aggregate_Columns_Description'.
            /// </summary>
            public const string Aggregate_Columns_Description = "Aggregate_Columns_Description";
        

            /// <summary>
            /// Stores the resource name 'EncryptText_Description'.
            /// </summary>
            public const string EncryptText_Description = "EncryptText_Description";
        

            /// <summary>
            /// Stores the resource name 'Common_ContinueOnError'.
            /// </summary>
            public const string Common_ContinueOnError = "Common_ContinueOnError";
        

            /// <summary>
            /// Stores the resource name 'EncryptText_Result_Description'.
            /// </summary>
            public const string EncryptText_Result_Description = "EncryptText_Result_Description";
        

            /// <summary>
            /// Stores the resource name 'Next_Description'.
            /// </summary>
            public const string Next_Description = "Next_Description";
        

            /// <summary>
            /// Stores the resource name 'CultureScope_Description'.
            /// </summary>
            public const string CultureScope_Description = "CultureScope_Description";
        

            /// <summary>
            /// Stores the resource name 'ExtractDataColumnValues_TypeArgument_Description'.
            /// </summary>
            public const string ExtractDataColumnValues_TypeArgument_Description = "ExtractDataColumnValues_TypeArgument_Description";
        

            /// <summary>
            /// Stores the resource name 'CleanUpFolder_DisplayName'.
            /// </summary>
            public const string CleanUpFolder_DisplayName = "CleanUpFolder_DisplayName";
        

            /// <summary>
            /// Stores the resource name 'RemoveDataColumns_DisplayName'.
            /// </summary>
            public const string RemoveDataColumns_DisplayName = "RemoveDataColumns_DisplayName";
        

            /// <summary>
            /// Stores the resource name 'RemoveEmptyRows_Operator_Description'.
            /// </summary>
            public const string RemoveEmptyRows_Operator_Description = "RemoveEmptyRows_Operator_Description";
        

            /// <summary>
            /// Stores the resource name 'EncryptDataTable_Iterations_Description'.
            /// </summary>
            public const string EncryptDataTable_Iterations_Description = "EncryptDataTable_Iterations_Description";
        

            /// <summary>
            /// Stores the resource name 'ZipEntriesCount_DisplayName'.
            /// </summary>
            public const string ZipEntriesCount_DisplayName = "ZipEntriesCount_DisplayName";
        

            /// <summary>
            /// Stores the resource name 'Iterate_Description'.
            /// </summary>
            public const string Iterate_Description = "Iterate_Description";
        

            /// <summary>
            /// Stores the resource name 'Zip_TextEncoding_Description'.
            /// </summary>
            public const string Zip_TextEncoding_Description = "Zip_TextEncoding_Description";
        

            /// <summary>
            /// Stores the resource name 'Stopwatch_Description'.
            /// </summary>
            public const string Stopwatch_Description = "Stopwatch_Description";
        

            /// <summary>
            /// Stores the resource name 'Decrement_Description'.
            /// </summary>
            public const string Decrement_Description = "Decrement_Description";
        

            /// <summary>
            /// Stores the resource name 'RemoveDuplicateRows_Description'.
            /// </summary>
            public const string RemoveDuplicateRows_Description = "RemoveDuplicateRows_Description";
        

            /// <summary>
            /// Stores the resource name 'DecryptDataTable_ParallelProcessing_Description'.
            /// </summary>
            public const string DecryptDataTable_ParallelProcessing_Description = "DecryptDataTable_ParallelProcessing_Description";
        

            /// <summary>
            /// Stores the resource name 'Iterate_ErrorMsg_IterationsMinValue'.
            /// </summary>
            public const string Iterate_ErrorMsg_IterationsMinValue = "Iterate_ErrorMsg_IterationsMinValue";
        

            /// <summary>
            /// Stores the resource name 'Aggregate_InputDataTable_Description'.
            /// </summary>
            public const string Aggregate_InputDataTable_Description = "Aggregate_InputDataTable_Description";
        

            /// <summary>
            /// Stores the resource name 'IsTrue_DisplayName'.
            /// </summary>
            public const string IsTrue_DisplayName = "IsTrue_DisplayName";
        

            /// <summary>
            /// Stores the resource name 'DataTableToText_DisplayName'.
            /// </summary>
            public const string DataTableToText_DisplayName = "DataTableToText_DisplayName";
        

            /// <summary>
            /// Stores the resource name 'RemoveDuplicateRows_Columns_Description'.
            /// </summary>
            public const string RemoveDuplicateRows_Columns_Description = "RemoveDuplicateRows_Columns_Description";
        

            /// <summary>
            /// Stores the resource name 'WaitFile_Timeout_Description'.
            /// </summary>
            public const string WaitFile_Timeout_Description = "WaitFile_Timeout_Description";
        

            /// <summary>
            /// Stores the resource name 'Aggregate_Description'.
            /// </summary>
            public const string Aggregate_Description = "Aggregate_Description";
        

            /// <summary>
            /// Stores the resource name 'ExtractDataColumnValues_Column_Description'.
            /// </summary>
            public const string ExtractDataColumnValues_Column_Description = "ExtractDataColumnValues_Column_Description";
        

            /// <summary>
            /// Stores the resource name 'ExtractDataColumnValues_Description'.
            /// </summary>
            public const string ExtractDataColumnValues_Description = "ExtractDataColumnValues_Description";
        

            /// <summary>
            /// Stores the resource name 'DataRowToDictionary_DisplayName'.
            /// </summary>
            public const string DataRowToDictionary_DisplayName = "DataRowToDictionary_DisplayName";
        

            /// <summary>
            /// Stores the resource name 'CheckPoint_Description'.
            /// </summary>
            public const string CheckPoint_Description = "CheckPoint_Description";
        

            /// <summary>
            /// Stores the resource name 'EnumerateFiles_DisplayName'.
            /// </summary>
            public const string EnumerateFiles_DisplayName = "EnumerateFiles_DisplayName";
        

            /// <summary>
            /// Stores the resource name 'RemoveDataColumns_Description'.
            /// </summary>
            public const string RemoveDataColumns_Description = "RemoveDataColumns_Description";
        

            /// <summary>
            /// Stores the resource name 'WaitFile_WaitForExist_Description'.
            /// </summary>
            public const string WaitFile_WaitForExist_Description = "WaitFile_WaitForExist_Description";
        

            /// <summary>
            /// Stores the resource name 'InputOutput_Category'.
            /// </summary>
            public const string InputOutput_Category = "InputOutput_Category";
        

            /// <summary>
            /// Stores the resource name 'EncryptText_Iterations_Description'.
            /// </summary>
            public const string EncryptText_Iterations_Description = "EncryptText_Iterations_Description";
        

            /// <summary>
            /// Stores the resource name 'Unzip_Overwrite_Description'.
            /// </summary>
            public const string Unzip_Overwrite_Description = "Unzip_Overwrite_Description";
        

            /// <summary>
            /// Stores the resource name 'DataTableToText_Result_Description'.
            /// </summary>
            public const string DataTableToText_Result_Description = "DataTableToText_Result_Description";
        

            /// <summary>
            /// Stores the resource name 'Common_Category'.
            /// </summary>
            public const string Common_Category = "Common_Category";
        

            /// <summary>
            /// Stores the resource name 'Iterate_Index_Description'.
            /// </summary>
            public const string Iterate_Index_Description = "Iterate_Index_Description";
        

            /// <summary>
            /// Stores the resource name 'DecryptText_Iterations_Description'.
            /// </summary>
            public const string DecryptText_Iterations_Description = "DecryptText_Iterations_Description";
        

            /// <summary>
            /// Stores the resource name 'Zip_ZipFilePath_Description'.
            /// </summary>
            public const string Zip_ZipFilePath_Description = "Zip_ZipFilePath_Description";
        

            /// <summary>
            /// Stores the resource name 'DecryptText_Algorithm_Description'.
            /// </summary>
            public const string DecryptText_Algorithm_Description = "DecryptText_Algorithm_Description";
        

            /// <summary>
            /// Stores the resource name 'PromoteHeaders_DisplayName'.
            /// </summary>
            public const string PromoteHeaders_DisplayName = "PromoteHeaders_DisplayName";
        

            /// <summary>
            /// Stores the resource name 'DataTableToText_Description'.
            /// </summary>
            public const string DataTableToText_Description = "DataTableToText_Description";
        

            /// <summary>
            /// Stores the resource name 'Decrement_ErrorMsg_MinValue'.
            /// </summary>
            public const string Decrement_ErrorMsg_MinValue = "Decrement_ErrorMsg_MinValue";
        

            /// <summary>
            /// Stores the resource name 'EncryptText_Algorithm_Description'.
            /// </summary>
            public const string EncryptText_Algorithm_Description = "EncryptText_Algorithm_Description";
        

            /// <summary>
            /// Stores the resource name 'DictionaryToDataTable_DisplayName'.
            /// </summary>
            public const string DictionaryToDataTable_DisplayName = "DictionaryToDataTable_DisplayName";
        

            /// <summary>
            /// Stores the resource name 'CleanUpFolder_Description'.
            /// </summary>
            public const string CleanUpFolder_Description = "CleanUpFolder_Description";
        

            /// <summary>
            /// Stores the resource name 'Increment_ErrorMsg_MinValue'.
            /// </summary>
            public const string Increment_ErrorMsg_MinValue = "Increment_ErrorMsg_MinValue";
        

            /// <summary>
            /// Stores the resource name 'PromoteHeaders_InputDataTable_Description'.
            /// </summary>
            public const string PromoteHeaders_InputDataTable_Description = "PromoteHeaders_InputDataTable_Description";
        

            /// <summary>
            /// Stores the resource name 'RemoveDataColumns_Columns_Description'.
            /// </summary>
            public const string RemoveDataColumns_Columns_Description = "RemoveDataColumns_Columns_Description";
        

            /// <summary>
            /// Stores the resource name 'Exit_Condition_Description'.
            /// </summary>
            public const string Exit_Condition_Description = "Exit_Condition_Description";
        

            /// <summary>
            /// Stores the resource name 'Output_Category'.
            /// </summary>
            public const string Output_Category = "Output_Category";
        

            /// <summary>
            /// Stores the resource name 'EncryptText_TextEncoding_Description'.
            /// </summary>
            public const string EncryptText_TextEncoding_Description = "EncryptText_TextEncoding_Description";
        

            /// <summary>
            /// Stores the resource name 'TransposeData_InputDataTable_Description'.
            /// </summary>
            public const string TransposeData_InputDataTable_Description = "TransposeData_InputDataTable_Description";
        

            /// <summary>
            /// Stores the resource name 'Container_Description'.
            /// </summary>
            public const string Container_Description = "Container_Description";
        

            /// <summary>
            /// Stores the resource name 'RemoveEmptyRows_DisplayName'.
            /// </summary>
            public const string RemoveEmptyRows_DisplayName = "RemoveEmptyRows_DisplayName";
        

            /// <summary>
            /// Stores the resource name 'TransposeData_DisplayName'.
            /// </summary>
            public const string TransposeData_DisplayName = "TransposeData_DisplayName";
        

            /// <summary>
            /// Stores the resource name 'DataRowToDictionary_InputDataRow_Description'.
            /// </summary>
            public const string DataRowToDictionary_InputDataRow_Description = "DataRowToDictionary_InputDataRow_Description";
        

            /// <summary>
            /// Stores the resource name 'EncryptDataTable_Columns_Description'.
            /// </summary>
            public const string EncryptDataTable_Columns_Description = "EncryptDataTable_Columns_Description";
        

            /// <summary>
            /// Stores the resource name 'Zip_AutoRenaming_Description'.
            /// </summary>
            public const string Zip_AutoRenaming_Description = "Zip_AutoRenaming_Description";
        

            /// <summary>
            /// Stores the resource name 'CultureScope_CultureName_Description'.
            /// </summary>
            public const string CultureScope_CultureName_Description = "CultureScope_CultureName_Description";
        

            /// <summary>
            /// Stores the resource name 'RemoveDuplicateRows_DisplayName'.
            /// </summary>
            public const string RemoveDuplicateRows_DisplayName = "RemoveDuplicateRows_DisplayName";
        

            /// <summary>
            /// Stores the resource name 'EncryptText_Text_Description'.
            /// </summary>
            public const string EncryptText_Text_Description = "EncryptText_Text_Description";
        

            /// <summary>
            /// Stores the resource name 'WaitFile_ErrorMsg_FilePathDoesNotExists'.
            /// </summary>
            public const string WaitFile_ErrorMsg_FilePathDoesNotExists = "WaitFile_ErrorMsg_FilePathDoesNotExists";
        

            /// <summary>
            /// Stores the resource name 'DecryptDataTable_InputDataTable_Description'.
            /// </summary>
            public const string DecryptDataTable_InputDataTable_Description = "DecryptDataTable_InputDataTable_Description";
        

            /// <summary>
            /// Stores the resource name 'Stopwatch_Method_Description'.
            /// </summary>
            public const string Stopwatch_Method_Description = "Stopwatch_Method_Description";
        

            /// <summary>
            /// Stores the resource name 'Zip_FilesCount_Description'.
            /// </summary>
            public const string Zip_FilesCount_Description = "Zip_FilesCount_Description";
        

            /// <summary>
            /// Stores the resource name 'DecryptText_Result_Description'.
            /// </summary>
            public const string DecryptText_Result_Description = "DecryptText_Result_Description";
        

            /// <summary>
            /// Stores the resource name 'WaitDynamicFile_FileInfo_Description'.
            /// </summary>
            public const string WaitDynamicFile_FileInfo_Description = "WaitDynamicFile_FileInfo_Description";
        

            /// <summary>
            /// Stores the resource name 'AddRangeToCollection_Description'.
            /// </summary>
            public const string AddRangeToCollection_Description = "AddRangeToCollection_Description";
        

            /// <summary>
            /// Stores the resource name 'Iterate_Reverse_Description'.
            /// </summary>
            public const string Iterate_Reverse_Description = "Iterate_Reverse_Description";
        

            /// <summary>
            /// Stores the resource name 'DictionaryToDataTable_OutputDataTable_Description'.
            /// </summary>
            public const string DictionaryToDataTable_OutputDataTable_Description = "DictionaryToDataTable_OutputDataTable_Description";
        

            /// <summary>
            /// Stores the resource name 'EncryptDataTable_Sort_Description'.
            /// </summary>
            public const string EncryptDataTable_Sort_Description = "EncryptDataTable_Sort_Description";
        

            /// <summary>
            /// Stores the resource name 'WaitDynamicFile_Interval_Description'.
            /// </summary>
            public const string WaitDynamicFile_Interval_Description = "WaitDynamicFile_Interval_Description";
        

            /// <summary>
            /// Stores the resource name 'Zip_CompressionLevel_Description'.
            /// </summary>
            public const string Zip_CompressionLevel_Description = "Zip_CompressionLevel_Description";
        

            /// <summary>
            /// Stores the resource name 'AddRangeToCollection_ErrorMsg_ItemsNull'.
            /// </summary>
            public const string AddRangeToCollection_ErrorMsg_ItemsNull = "AddRangeToCollection_ErrorMsg_ItemsNull";
        

            /// <summary>
            /// Stores the resource name 'WaitDynamicFile_SearchPattern_Description'.
            /// </summary>
            public const string WaitDynamicFile_SearchPattern_Description = "WaitDynamicFile_SearchPattern_Description";
        

            /// <summary>
            /// Stores the resource name 'EncryptDataTable_InputDataTable_Description'.
            /// </summary>
            public const string EncryptDataTable_InputDataTable_Description = "EncryptDataTable_InputDataTable_Description";
        

            /// <summary>
            /// Stores the resource name 'CleanUpFolder_DeleteEmptyFolders_Description'.
            /// </summary>
            public const string CleanUpFolder_DeleteEmptyFolders_Description = "CleanUpFolder_DeleteEmptyFolders_Description";
        

            /// <summary>
            /// Stores the resource name 'Unzip_ErrorMsg_OutsideDir'.
            /// </summary>
            public const string Unzip_ErrorMsg_OutsideDir = "Unzip_ErrorMsg_OutsideDir";
        

            /// <summary>
            /// Stores the resource name 'DecryptDataTable_Algorithm_Description'.
            /// </summary>
            public const string DecryptDataTable_Algorithm_Description = "DecryptDataTable_Algorithm_Description";
        

            /// <summary>
            /// Stores the resource name 'DecryptDataTable_Description'.
            /// </summary>
            public const string DecryptDataTable_Description = "DecryptDataTable_Description";
        

            /// <summary>
            /// Stores the resource name 'RemoveEmptyRows_Mode_Description'.
            /// </summary>
            public const string RemoveEmptyRows_Mode_Description = "RemoveEmptyRows_Mode_Description";
        

            /// <summary>
            /// Stores the resource name 'DecryptDataTable_Sort_Description'.
            /// </summary>
            public const string DecryptDataTable_Sort_Description = "DecryptDataTable_Sort_Description";
        

            /// <summary>
            /// Stores the resource name 'CleanUpFolder_SearchPattern_Description'.
            /// </summary>
            public const string CleanUpFolder_SearchPattern_Description = "CleanUpFolder_SearchPattern_Description";
        

            /// <summary>
            /// Stores the resource name 'Stopwatch_StopwatchObj_Description'.
            /// </summary>
            public const string Stopwatch_StopwatchObj_Description = "Stopwatch_StopwatchObj_Description";
        

            /// <summary>
            /// Stores the resource name 'Unzip_ErrorMsg_DirNameWithData'.
            /// </summary>
            public const string Unzip_ErrorMsg_DirNameWithData = "Unzip_ErrorMsg_DirNameWithData";
        

            /// <summary>
            /// Stores the resource name 'EnumerateFiles_Result_Description'.
            /// </summary>
            public const string EnumerateFiles_Result_Description = "EnumerateFiles_Result_Description";
        

            /// <summary>
            /// Stores the resource name 'ExtractDataColumnValues_DefaultValue_DisplayName'.
            /// </summary>
            public const string ExtractDataColumnValues_DefaultValue_DisplayName = "ExtractDataColumnValues_DefaultValue_DisplayName";
        

            /// <summary>
            /// Stores the resource name 'Stopwatch_StopwatchObj_DisplayName'.
            /// </summary>
            public const string Stopwatch_StopwatchObj_DisplayName = "Stopwatch_StopwatchObj_DisplayName";
        

            /// <summary>
            /// Stores the resource name 'RemoveEmptyRows_InputDataTable_Description'.
            /// </summary>
            public const string RemoveEmptyRows_InputDataTable_Description = "RemoveEmptyRows_InputDataTable_Description";
        

            /// <summary>
            /// Stores the resource name 'AddRangeToCollection_Collection_Description'.
            /// </summary>
            public const string AddRangeToCollection_Collection_Description = "AddRangeToCollection_Collection_Description";
        

            /// <summary>
            /// Stores the resource name 'WaitFile_Interval_Description'.
            /// </summary>
            public const string WaitFile_Interval_Description = "WaitFile_Interval_Description";
        

            /// <summary>
            /// Stores the resource name 'EncryptText_DisplayName'.
            /// </summary>
            public const string EncryptText_DisplayName = "EncryptText_DisplayName";
        

            /// <summary>
            /// Stores the resource name 'ZipEntriesCount_ZipFilePath_Description'.
            /// </summary>
            public const string ZipEntriesCount_ZipFilePath_Description = "ZipEntriesCount_ZipFilePath_Description";
        

            /// <summary>
            /// Stores the resource name 'Aggregate_InputDataTable_DisplayName'.
            /// </summary>
            public const string Aggregate_InputDataTable_DisplayName = "Aggregate_InputDataTable_DisplayName";
        

            /// <summary>
            /// Stores the resource name 'Decrement_Value_Description'.
            /// </summary>
            public const string Decrement_Value_Description = "Decrement_Value_Description";
        

            /// <summary>
            /// Stores the resource name 'Aggregate_Detached_Description'.
            /// </summary>
            public const string Aggregate_Detached_Description = "Aggregate_Detached_Description";
        

            /// <summary>
            /// Stores the resource name 'RemoveEmptyRows_Description'.
            /// </summary>
            public const string RemoveEmptyRows_Description = "RemoveEmptyRows_Description";
        

            /// <summary>
            /// Stores the resource name 'Unzip_ExtractTo_Description'.
            /// </summary>
            public const string Unzip_ExtractTo_Description = "Unzip_ExtractTo_Description";
        

            /// <summary>
            /// Stores the resource name 'EncryptDataTable_ColumnNames_Description'.
            /// </summary>
            public const string EncryptDataTable_ColumnNames_Description = "EncryptDataTable_ColumnNames_Description";
        

            /// <summary>
            /// Stores the resource name 'PromoteHeaders_OutputDataTable_Description'.
            /// </summary>
            public const string PromoteHeaders_OutputDataTable_Description = "PromoteHeaders_OutputDataTable_Description";
        

            /// <summary>
            /// Stores the resource name 'DataTableToText_DateTimeFormat_Description'.
            /// </summary>
            public const string DataTableToText_DateTimeFormat_Description = "DataTableToText_DateTimeFormat_Description";
        

            /// <summary>
            /// Stores the resource name 'RemoveDataColumns_DataTable_Description'.
            /// </summary>
            public const string RemoveDataColumns_DataTable_Description = "RemoveDataColumns_DataTable_Description";
        

            /// <summary>
            /// Stores the resource name 'CheckPoint_Data_Description'.
            /// </summary>
            public const string CheckPoint_Data_Description = "CheckPoint_Data_Description";
        

            /// <summary>
            /// Stores the resource name 'WaitDynamicFile_Timeout_Description'.
            /// </summary>
            public const string WaitDynamicFile_Timeout_Description = "WaitDynamicFile_Timeout_Description";
        

            /// <summary>
            /// Stores the resource name 'WaitDynamicFile_AfterCreationTime_Description'.
            /// </summary>
            public const string WaitDynamicFile_AfterCreationTime_Description = "WaitDynamicFile_AfterCreationTime_Description";
        

            /// <summary>
            /// Stores the resource name 'Increment_Variable_Description'.
            /// </summary>
            public const string Increment_Variable_Description = "Increment_Variable_Description";
        

            /// <summary>
            /// Stores the resource name 'Validation_TypeError'.
            /// </summary>
            public const string Validation_TypeError = "Validation_TypeError";
        

            /// <summary>
            /// Stores the resource name 'TransposeData_Description'.
            /// </summary>
            public const string TransposeData_Description = "TransposeData_Description";
        

            /// <summary>
            /// Stores the resource name 'Unzip_ZipFilePath_Description'.
            /// </summary>
            public const string Unzip_ZipFilePath_Description = "Unzip_ZipFilePath_Description";
        

            /// <summary>
            /// Stores the resource name 'WaitDynamicFile_DisplayName'.
            /// </summary>
            public const string WaitDynamicFile_DisplayName = "WaitDynamicFile_DisplayName";
        

            /// <summary>
            /// Stores the resource name 'WaitDynamicFile_Description'.
            /// </summary>
            public const string WaitDynamicFile_Description = "WaitDynamicFile_Description";
        

            /// <summary>
            /// Stores the resource name 'WaitFile_DisplayName'.
            /// </summary>
            public const string WaitFile_DisplayName = "WaitFile_DisplayName";
        

            /// <summary>
            /// Stores the resource name 'DecryptText_DisplayName'.
            /// </summary>
            public const string DecryptText_DisplayName = "DecryptText_DisplayName";
        

            /// <summary>
            /// Stores the resource name 'Unzip_Description'.
            /// </summary>
            public const string Unzip_Description = "Unzip_Description";
        

            /// <summary>
            /// Stores the resource name 'ZipEntriesCount_EntriesCount_Description'.
            /// </summary>
            public const string ZipEntriesCount_EntriesCount_Description = "ZipEntriesCount_EntriesCount_Description";
        

            /// <summary>
            /// Stores the resource name 'Options_Category'.
            /// </summary>
            public const string Options_Category = "Options_Category";
        

            /// <summary>
            /// Stores the resource name 'Input_Category'.
            /// </summary>
            public const string Input_Category = "Input_Category";
        

            /// <summary>
            /// Stores the resource name 'TransposeData_OutputDataTable_Description'.
            /// </summary>
            public const string TransposeData_OutputDataTable_Description = "TransposeData_OutputDataTable_Description";
        

            /// <summary>
            /// Stores the resource name 'EncryptDataTable_Description'.
            /// </summary>
            public const string EncryptDataTable_Description = "EncryptDataTable_Description";
        

            /// <summary>
            /// Stores the resource name 'DecryptText_Description'.
            /// </summary>
            public const string DecryptText_Description = "DecryptText_Description";
        

            /// <summary>
            /// Stores the resource name 'ExtractDataColumnValues_DisplayName'.
            /// </summary>
            public const string ExtractDataColumnValues_DisplayName = "ExtractDataColumnValues_DisplayName";
        

            /// <summary>
            /// Stores the resource name 'WaitDynamicFile_DirectoryPath_Description'.
            /// </summary>
            public const string WaitDynamicFile_DirectoryPath_Description = "WaitDynamicFile_DirectoryPath_Description";
        

            /// <summary>
            /// Stores the resource name 'ZipEntriesCount_FoldersCount_Description'.
            /// </summary>
            public const string ZipEntriesCount_FoldersCount_Description = "ZipEntriesCount_FoldersCount_Description";
        

            /// <summary>
            /// Stores the resource name 'RemoveEmptyRows_OutputDataTable_Description'.
            /// </summary>
            public const string RemoveEmptyRows_OutputDataTable_Description = "RemoveEmptyRows_OutputDataTable_Description";
        

            /// <summary>
            /// Stores the resource name 'PromoteHeaders_Description'.
            /// </summary>
            public const string PromoteHeaders_Description = "PromoteHeaders_Description";
        

            /// <summary>
            /// Stores the resource name 'DecryptDataTable_Columns_Description'.
            /// </summary>
            public const string DecryptDataTable_Columns_Description = "DecryptDataTable_Columns_Description";
        

            /// <summary>
            /// Stores the resource name 'EncryptDataTable_TextEncoding_Description'.
            /// </summary>
            public const string EncryptDataTable_TextEncoding_Description = "EncryptDataTable_TextEncoding_Description";
        

            /// <summary>
            /// Stores the resource name 'DictionaryToDataTable_Description'.
            /// </summary>
            public const string DictionaryToDataTable_Description = "DictionaryToDataTable_Description";
        

            /// <summary>
            /// Stores the resource name 'ExtractDataColumnValues_DataTable_Description'.
            /// </summary>
            public const string ExtractDataColumnValues_DataTable_Description = "ExtractDataColumnValues_DataTable_Description";
        

            /// <summary>
            /// Stores the resource name 'CleanUpFolder_Folder_Description'.
            /// </summary>
            public const string CleanUpFolder_Folder_Description = "CleanUpFolder_Folder_Description";
        

            /// <summary>
            /// Stores the resource name 'Decrement_Variable_Description'.
            /// </summary>
            public const string Decrement_Variable_Description = "Decrement_Variable_Description";
        

            /// <summary>
            /// Stores the resource name 'RemoveEmptyRows_Columns_Description'.
            /// </summary>
            public const string RemoveEmptyRows_Columns_Description = "RemoveEmptyRows_Columns_Description";
        

            /// <summary>
            /// Stores the resource name 'EnumerateFiles_Path_Description'.
            /// </summary>
            public const string EnumerateFiles_Path_Description = "EnumerateFiles_Path_Description";
        

            /// <summary>
            /// Stores the resource name 'Increment_Value_Description'.
            /// </summary>
            public const string Increment_Value_Description = "Increment_Value_Description";
        

            /// <summary>
            /// Stores the resource name 'DataTableToText_TextFormat_Description'.
            /// </summary>
            public const string DataTableToText_TextFormat_Description = "DataTableToText_TextFormat_Description";
        

            /// <summary>
            /// Stores the resource name 'DecryptDataTable_OutputDataTable_Description'.
            /// </summary>
            public const string DecryptDataTable_OutputDataTable_Description = "DecryptDataTable_OutputDataTable_Description";
        

            /// <summary>
            /// Stores the resource name 'Iterate_Iterations_Description'.
            /// </summary>
            public const string Iterate_Iterations_Description = "Iterate_Iterations_Description";
        

            /// <summary>
            /// Stores the resource name 'Aggregate_Function_Description'.
            /// </summary>
            public const string Aggregate_Function_Description = "Aggregate_Function_Description";
        

            /// <summary>
            /// Stores the resource name 'Exit_Description'.
            /// </summary>
            public const string Exit_Description = "Exit_Description";
        

            /// <summary>
            /// Stores the resource name 'WaitFile_ErrorMsg_IntervalRange'.
            /// </summary>
            public const string WaitFile_ErrorMsg_IntervalRange = "WaitFile_ErrorMsg_IntervalRange";
        

            /// <summary>
            /// Stores the resource name 'RemoveDuplicateRows_OutputDataTable_Description'.
            /// </summary>
            public const string RemoveDuplicateRows_OutputDataTable_Description = "RemoveDuplicateRows_OutputDataTable_Description";
        

            /// <summary>
            /// Stores the resource name 'CultureScope_DisplayName'.
            /// </summary>
            public const string CultureScope_DisplayName = "CultureScope_DisplayName";
        

            /// <summary>
            /// Stores the resource name 'IsTrue_Value_Description'.
            /// </summary>
            public const string IsTrue_Value_Description = "IsTrue_Value_Description";
        

            /// <summary>
            /// Stores the resource name 'ExtractDataColumnValues_Result_Description'.
            /// </summary>
            public const string ExtractDataColumnValues_Result_Description = "ExtractDataColumnValues_Result_Description";
        

            /// <summary>
            /// Stores the resource name 'AddRangeToCollection_ErrorMsg_CollectionNull'.
            /// </summary>
            public const string AddRangeToCollection_ErrorMsg_CollectionNull = "AddRangeToCollection_ErrorMsg_CollectionNull";
        

            /// <summary>
            /// Stores the resource name 'WaitFile_Description'.
            /// </summary>
            public const string WaitFile_Description = "WaitFile_Description";
        

            /// <summary>
            /// Stores the resource name 'DecryptText_Text_Description'.
            /// </summary>
            public const string DecryptText_Text_Description = "DecryptText_Text_Description";
        

            /// <summary>
            /// Stores the resource name 'WaitFile_FilePath_Description'.
            /// </summary>
            public const string WaitFile_FilePath_Description = "WaitFile_FilePath_Description";
        

            /// <summary>
            /// Stores the resource name 'EnumerateFiles_SearchPattern_Description'.
            /// </summary>
            public const string EnumerateFiles_SearchPattern_Description = "EnumerateFiles_SearchPattern_Description";
        

            /// <summary>
            /// Stores the resource name 'EnumerateFiles_SearchOption_Description'.
            /// </summary>
            public const string EnumerateFiles_SearchOption_Description = "EnumerateFiles_SearchOption_Description";
        
        }
    }
}
    

