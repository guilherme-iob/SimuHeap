#define MyAppName "SimuHeap"
#define MyAppVersion "1.0.0"
#define MyAppPublisher "Guilherme Iob"
#define MyAppExeName "SimuHeap.exe"

[Setup]
AppId={{F8803780-29EB-46CE-BAB5-CA3CD44874CB}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}

DefaultDirName={autopf}\{#MyAppName}
DefaultGroupName={#MyAppName}

OutputDir=Output
OutputBaseFilename=SimuHeap-Setup-{#MyAppVersion}

Compression=lzma2
SolidCompression=yes

ArchitecturesAllowed=x64compatible
ArchitecturesInstallIn64BitMode=x64compatible

WizardStyle=modern

UninstallDisplayIcon={app}\{#MyAppExeName}

[Languages]
Name: "brazilianportuguese"; MessagesFile: "compiler:Languages\BrazilianPortuguese.isl"

[Tasks]
Name: "desktopicon"; Description: "Criar um atalho na área de trabalho"; GroupDescription: "Atalhos adicionais:"; Flags: unchecked

[Files]
Source: "..\SimuHeap\SimuHeap\bin\Release\net9.0-windows\publish\win-x64\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

Source: "Fonts\Lato-Regular.ttf"; DestDir: "{autofonts}"; FontInstall: "Lato"; Flags: onlyifdoesntexist uninsneveruninstall
Source: "Fonts\Lato-Bold.ttf"; DestDir: "{autofonts}"; FontInstall: "Lato Bold"; Flags: onlyifdoesntexist uninsneveruninstall
Source: "Fonts\Lato-Italic.ttf"; DestDir: "{autofonts}"; FontInstall: "Lato Italic"; Flags: onlyifdoesntexist uninsneveruninstall
Source: "Fonts\Lato-BoldItalic.ttf"; DestDir: "{autofonts}"; FontInstall: "Lato Bold Italic"; Flags: onlyifdoesntexist uninsneveruninstall

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "Executar {#MyAppName}"; Flags: nowait postinstall skipifsilent