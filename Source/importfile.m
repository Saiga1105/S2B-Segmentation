function tableout = importfile(workbookFile,sheetName,startRow,endRow)
%IMPORTFILE Import data from a spreadsheet
%   DATA = IMPORTFILE(FILE) reads data from the first worksheet in the
%   Microsoft Excel spreadsheet file named FILE and returns the data as a
%   table.
%
%   DATA = IMPORTFILE(FILE,SHEET) reads from the specified worksheet.
%
%   DATA = IMPORTFILE(FILE,SHEET,STARTROW,ENDROW) reads from the specified
%   worksheet for the specified row interval(s). Specify STARTROW and
%   ENDROW as a pair of scalars or vectors of matching size for
%   dis-contiguous row intervals. To read to the end of the file specify an
%   ENDROW of inf.
%
%	Non-numeric cells are replaced with: NaN
%
% Example:
%   labels1 = importfile('labels.xlsx','Blad1',1,152);
%
%   See also XLSREAD.

% Auto-generated by MATLAB on 2017/07/31 11:07:21

%% Input handling

% If no sheet is specified, read first sheet
if nargin == 1 || isempty(sheetName)
    sheetName = 1;
end

% If row start and end points are not specified, define defaults
if nargin <= 3
    startRow = 1;
    endRow = 152;
end

%% Import the data
[~, ~, raw] = xlsread(workbookFile, sheetName, sprintf('A%d:AR%d',startRow(1),endRow(1)));
for block=2:length(startRow)
    [~, ~, tmpRawBlock] = xlsread(workbookFile, sheetName, sprintf('A%d:AR%d',startRow(block),endRow(block)));
    raw = [raw;tmpRawBlock]; %#ok<AGROW>
end
raw(cellfun(@(x) ~isempty(x) && isnumeric(x) && isnan(x),raw)) = {''};

%% Replace non-numeric cells with NaN
R = cellfun(@(x) ~isnumeric(x) && ~islogical(x),raw); % Find non-numeric cells
raw(R) = {NaN}; % Replace non-numeric cells

%% Create output variable
I = cellfun(@(x) ischar(x), raw);
raw(I) = {NaN};
data = reshape([raw{:}],size(raw));

%% Create table
tableout = table;

%% Allocate imported array to column variable names
tableout.VarName1 = data(:,1);
tableout.VarName2 = data(:,2);
tableout.VarName3 = data(:,3);
tableout.VarName4 = data(:,4);
tableout.VarName5 = data(:,5);
tableout.VarName6 = data(:,6);
tableout.VarName7 = data(:,7);
tableout.VarName8 = data(:,8);
tableout.VarName9 = data(:,9);
tableout.VarName10 = data(:,10);
tableout.VarName11 = data(:,11);
tableout.VarName12 = data(:,12);
tableout.VarName13 = data(:,13);
tableout.VarName14 = data(:,14);
tableout.VarName15 = data(:,15);
tableout.VarName16 = data(:,16);
tableout.VarName17 = data(:,17);
tableout.VarName18 = data(:,18);
tableout.VarName19 = data(:,19);
tableout.VarName20 = data(:,20);
tableout.VarName21 = data(:,21);
tableout.VarName22 = data(:,22);
tableout.VarName23 = data(:,23);
tableout.VarName24 = data(:,24);
tableout.VarName25 = data(:,25);
tableout.VarName26 = data(:,26);
tableout.VarName27 = data(:,27);
tableout.VarName28 = data(:,28);
tableout.VarName29 = data(:,29);
tableout.VarName30 = data(:,30);
tableout.VarName31 = data(:,31);
tableout.VarName32 = data(:,32);
tableout.VarName33 = data(:,33);
tableout.VarName34 = data(:,34);
tableout.VarName35 = data(:,35);
tableout.VarName36 = data(:,36);
tableout.VarName37 = data(:,37);
tableout.VarName38 = data(:,38);
tableout.VarName39 = data(:,39);
tableout.VarName40 = data(:,40);
tableout.VarName41 = data(:,41);
tableout.VarName42 = data(:,42);
tableout.VarName43 = data(:,43);
tableout.VarName44 = data(:,44);

