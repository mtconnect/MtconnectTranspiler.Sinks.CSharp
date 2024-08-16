using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.SupportingDocuments
{
	/// <summary>
	﻿/// Acronyms<br/><br /><i>API (API)</i><br /><i>BOM (BOM)</i><br /><i>DER (DER)</i><br /><i>DMC (DMC)</i><br /><i>SME (SME)</i><br /><i>URI (URI)</i><br /><i>URL (URL)</i><br /><i>URN (URN)</i><br /><i>UTC (UTC)</i><br /><br /><br /><i>2D (2D)</i><br /><i>3D (3D)</i><br /><i>AI (AI)</i><br /><i>ALM (ALM)</i><br /><i>AMT (AMT)</i><br /><i>ANSI (ANSI)</i><br /><i>AP (AP)</i><br /><i>ASME (ASME)</i><br /><i>ASTM (ASTM)</i><br /><i>AWS (AWS)</i><br /><i>BDD (BDD)</i><br /><i>BST (BST)</i><br /><i>CA (CA)</i><br /><i>CAD (CAD)</i><br /><i>CAE (CAE)</i><br /><i>CAI (CAI)</i><br /><i>CAM (CAM)</i><br /><i>CAx (CAx)</i><br /><i>CFD (CFD)</i><br /><i>CM (CM)</i><br /><i>CMS (CMS)</i><br /><i>CNRI (CNRI)</i><br /><i>CPM (CPM)</i><br /><i>CPM2 (CPM2)</i><br /><i>CPSC (CPSC)</i><br /><i>C\&R (C&R)</i><br /><i>cUAV (cUAV)</i><br /><i>DARPA (DARPA)</i><br /><i>DFM (DFM)</i><br /><i>DLA (DLA)</i><br /><i>DMSC (DMSC)</i><br /><i>DNS (DNS)</i><br /><i>DoD (DoD)</i><br /><i>DOI (DOI)</i><br /><i>DRM (DRM)</i><br /><i>ECR (ECR)</i><br /><i>ERP (ERP)</i><br /><i>FAA (FAA)</i><br /><i>FAIR (FAIR)</i><br /><i>FDA (FDA)</i><br /><i>FEA (FEA)</i><br /><i>GD\&T (GD&T)</i><br /><i>GID (GID)</i><br /><i>HTML (HTML)</i><br /><i>HTTP (HTTP)</i><br /><i>HTTPS (HTTPS)</i><br /><i>ID (ID)</i><br /><i>IEEE (IEEE)</i><br /><i>IIoT (IIoT)</i><br /><i>INCOSE (INCOSE)</i><br /><i>I/O (I/O)</i><br /><i>IP (IP)</i><br /><i>ISO (ISO)</i><br /><i>ISS (ISS)</i><br /><i>IT (IT)</i><br /><i>ITU-T (ITU-T)</i><br /><i>JSON (JSON)</i><br /><i>JT (JT)</i><br /><i>LHS (LHS)</i><br /><i>LIFT (LIFT)</i><br /><i>LOI (LOI)</i><br /><i>MAC (MAC)</i><br /><i>MADE (MADE)</i><br /><i>MBD (MBD)</i><br /><i>MBE (MBE)</i><br /><i>MBI (MBI)</i><br /><i>MBM (MBM)</i><br /><i>MBSD (MBSD)</i><br /><i>MBSE (MBSE)</i><br /><i>MEDALS (MEDALS)</i><br /><i>MES (MES)</i><br /><i>MOI (MOI)</i><br /><i>MTC (MTC)</i><br /><i>NASA (NASA)</i><br /><i>NC (NC)</i><br /><i>NIST (NIST)</i><br /><i>NNMI (NNMI)</i><br /><i>NSF (NSF)</i><br /><i>NTSC (NTSC)</i><br /><i>OASIS (OASIS)</i><br /><i>ODI (ODI)</i><br /><i>OEM (OEM)</i><br /><i>OOI (OOI)</i><br /><i>OSLC (OSLC)</i><br /><i>OSTP (OSTP)</i><br /><i>OT (OT)</i><br /><i>OWL (OWL)</i><br /><i>PDF (PDF)</i><br /><i>PDM (PDM)</i><br /><i>PDQ (PDQ)</i><br /><i>PHM (PHM)</i><br /><i>PI (PI)</i><br /><i>PLCS (PLCS)</i><br /><i>PLM (PLM)</i><br /><i>PLOT (PLOT)</i><br /><i>PMI (PMI)</i><br /><i>PRC (PRC)</i><br /><i>PSI (PSI)</i><br /><i>PTAB (PTAB)</i><br /><i>QIF (QIF)</i><br /><i>QMS (QMS)</i><br /><i>RDF (RDF)</i><br /><i>REST (REST)</i><br /><i>RII (RII)</i><br /><i>SaaS (SaaS)</i><br /><i>SAML (SAML)</i><br /><i>SC (SC)</i><br /><i>SDO (SDO)</i><br /><i>SFTP (SFTP)</i><br /><i>SKOS (SKOS)</i><br /><i>SLH (SLH)</i><br /><i>SLR (SLR)</i><br /><i>S/MIME (S/MIME)</i><br /><i>SMOPAC (SMOPAC)</i><br /><i>SMS Test Bed (sms)</i><br /><i>SOA (SOA)</i><br /><i>SPMM (SPMM)</i><br /><i>SSL (SSL)</i><br /><i>STEP (STEP)</i><br /><i>STEP AP242 (STEP AP242)</i><br /><i>STL (STL)</i><br /><i>SysML (SysML)</i><br /><i>TDP (TDP)</i><br /><i>TLS (TLS)</i><br /><i>TSM (TSM)</i><br /><i>UML (UML)</i><br /><i>UUID (UUID)</i><br /><i>V\&V (V&V)</i><br /><i>W3C (W3C)</i><br /><i>WSN (WSN)</i><br /><i>WWW (WWW)</i><br /><i>XML (XML)</i><br /><i>X.509-PKI (X.509-PKI)</i><br /><i>X.509-PMI (X.509-PMI)</i><br /><i>XSD (XSD)</i><br /><br /><i>OPC (OPC)</i><br /><i>UA (UA)</i><br /><i>UAL (UAL)</i><br /><i>HMI (HMI)</i><br /><i>PLC (PLC)</i><br /><i>SCADA (SCADA)</i><br /><i>TCP/IP (TCP/IP)</i><br /><i>CNC (CNC)</i><br /><br /><br /><i>MOM (MOM)</i><br /><i>PMS (PMS)</i><br /><i>ISV (ISV)</i><br /><i>MQTT (MQTT)</i><br /><i>CDATA (CDATA)</i><br /><i>NMTOKEN (NMTOKEN)</i><br /><i>QName (QName)</i><br /><i>XPath (XPath)</i><br /><br/><br/><br />MTConnect Class<br/>%   MTConnect Document Class    %<br /><br />\NeedsTeXFormat{LaTeX2e}<br />\ProvidesClass{mtconnect}[2018/02/13 LaTeX document class for MTConnect]<br /><br />%   Preliminary Declarations    %<br /><br />\LoadClass[12pt,letterpaper,twoside]{article}<br />\usepackage[utf8]{inputenc}<br />\usepackage[letterpaper,top=1.25in,%<br />            bottom=1.25in,footskip=0.5in]{geometry}<br /><br />\usepackage[citations,hybrid,smartEllipses,hashEnumerators,html,%<br />           pipeTables,tableCaptions,fencedCode,codeSpans,tightLists=false,%<br />           cacheDir=markdowncache]{markdown}%<br />\usepackage[absolute]{textpos}<br />\RequirePackage[htt]{hyphenat}				% Allow hyphenation of fixed space fonts<br />\RequirePackage{fancyvrb}<br />\RequirePackage{placeins}<br />\RequirePackage{booktabs}<br />\usepackage{morewrites}<br />\RequirePackage{times}					% Loads Adobe Times Roman Font (clone of Times New Roman)<br />\RequirePackage{mathptmx}				% Loads Adobe Times Roman Math Font<br />\RequirePackage{ifpdf}					% Enables switch between latex and pdflatex<br />\RequirePackage{stringstrings}			% Loads stringstrings to create Camel and Pascal case fonts<br />\RequirePackage{ifthen}					% Loads ifthen package for conditional statements<br />\RequirePackage[T1]{fontenc}			% Loads fontenc package for controlled vocabulary formatting<br />\let\BreakableUnderscore\undefined<br />\RequirePackage{graphicx}				% Loads graphicx package to include figures and images<br />\RequirePackage{fancyhdr}				% Loads fancyhdr package to modify headers and footers<br />%\RequirePackage[hyphens]{url}					% Loads url package to typeset URLs<br />\RequirePackage{lineno}					% Loads lineno package to apply line numbers to document<br />\RequirePackage{etoolbox}				% Loads etoolbox package to patch lineno package and suppress line numbers in section headings<br />\RequirePackage{sectsty}				% Loads sectsty package to modify font of section headings<br />\RequirePackage{xcolor}					% Loads xcolor package to define color for fonts and tables<br />\RequirePackage{colortbl}				% Loads colortbl package to provide colors for table shading<br />\RequirePackage{caption}				% Loads caption package to adjust caption font<br />\usepackage{listings}				% Loads listings package to typeset code samples<br />\lstset{ %default<br />    basicstyle=\footnotesize\fontfamily{pcr}\selectfont,<br />    numbers=left,<br />    stepnumber=1,<br />    xleftmargin=0.25in,<br />	breaklines=true<br />}<br />\renewcommand\lstlistingname{Example}<br />\RequirePackage{hyperref}				% Loads hyperref package to link TOC/LOF/LOT<br />\RequirePackage{tocloft}				% Loads tocloft package to format TOC/LOF/LOT<br />\RequirePackage[ampersand]{easylist}	% Loads easylist package to simplify lists using &<br />\RequirePackage[english]{babel}<br />\RequirePackage{csquotes}<br />\RequirePackage{xstring}<br />\RequirePackage{siunitx}<br />\RequirePackage{upgreek}<br />\RequirePackage{longtable}<br />\RequirePackage{enumitem}<br />\usepackage{tabularray}<br />\usepackage{amsmath}<br />\usepackage{amssymb}<br />\usepackage[normalem]{ulem} %For deprecated items<br />\RequirePackage[acronym,toc,numberedsection,%<br />  abbreviations,automake,nonumberlist,%<br />  section=subsection]{glossaries-extra}<br />\usepackage{mdframed}<br />\usepackage{nameref}<br />\usepackage[titletoc,title]{appendix}<br />\usepackage{hanging}<br />\usepackage{titlesec}<br />\usepackage{xargs}<br />\newcommand{\sectionbreak}{\clearpage}<br /><br />\usepackage[backend=biber,style=alphabetic,]{biblatex}<br />\defbibheading{bibliography}[\bibname]{%<br />  \subsection{#1}}<br /><br />\usepackage{titlesec}<br /><br />%   Watermark   %<br /><br />%\usepackage{background}<br />%\backgroundsetup{contents=DRAFT, opacity=0.3, color=cyan, scale=9}<br /><br />% Formatting for MTConnect with registration mark, which is required in title and footer. <br />\newcommand{\mtconnectregistered}{MTConnect\textsuperscript{\textregistered} }<br />% Formatting for MTConnect without registration mark, which can be used everywhere except title page(s) and footer. <br />%\newcommand{\mtconnect}{MTConnect } %Use MTConnect<br /><br />\newcommand{\storedstringPCR}[1]{{\fontfamily{pcr}\selectfont #1}}<br /><br />%    Page Layout    %<br /><br />\setlength\paperheight{11in}<br />\setlength\paperwidth{8.5in}<br />\setlength\oddsidemargin{0.25in}<br />\setlength\evensidemargin{0.25in}<br /><br />\setlength\parindent{0pt}<br />\setlength\parskip{1em}<br /><br />%   Title Page  %<br /><br />\newcommand\@docnum{}<br />\newcommand\@doctitle{}<br />\newcommand\@versionnum{}<br />\newcommand\@preparedfor{}<br />\newcommand\@preparedby{}<br />\newcommand\@preparedon{}<br />\newcommand\@preparedfrom{}<br />\newcommand{\docnum}[1]{\gdef\@docnum{#1}}<br />\newcommand{\doctitle}[1]{\gdef\@doctitle{#1}}<br />\newcommand{\versionnum}[1]{\gdef\@versionnum{#1}}<br />\newcommand{\preparedfor}[1]{\gdef\@preparedfor{#1}}<br />\newcommand{\preparedby}[1]{\gdef\@preparedby{#1}}<br />\newcommand{\preparedon}[1]{\gdef\@preparedon{#1}}<br />\newcommand{\preparedfrom}[1]{\gdef\@preparedfrom{#1}}<br /><br />\renewcommand{\maketitle}{%<br />	\begin{titlepage}%<br />    	\begin{flushleft}%<br />        	\includegraphics[width=0.5\linewidth]{mtconnect.png} \\%<br />        \end{flushleft}%<br />        \vfill%<br />        \begin{center}%<br />        	\Huge{\textbf{\mtconnectregistered Standard}} \\%<br />            \huge{\@docnum\ -- \@doctitle} \\%<br />            \LARGE{Version \@versionnum} \\%<br />        \end{center}%<br />        \vfill%<br />        \hspace*{\fill}%<br />		\begin{tabular}[t]{l@{}}%<br />			Prepared for: \@preparedfor \\%<br />			Prepared from: \@preparedfrom \\%<br />        	Prepared on: \@preparedon \\%<br />		\end{tabular}%<br />		\vfill%<br />		\noindent \footnotesize{\mtconnectregistered is a registered trademark of AMT - The Association for Manufacturing Technology. Use of MTConnect is limited to use as specified on \url{http://www.mtconnect.org/}.}%<br />    \end{titlepage}%<br />    \setcounter{page}{1}%<br />}<br /><br />%   Table of Contents/Figures/Tables    %<br /><br />\addto\captionsenglish{%<br />\renewcommand\contentsname{\color{mtc1} Table of Contents}}<br />\addto\captionsenglish{%<br />\renewcommand\listfigurename{\color{mtc1} Table of Figures}}<br />\addto\captionsenglish{%<br />\renewcommand\listtablename{\color{mtc1} List of Tables}}<br /><br />\renewcommand{\cftfigfont}{\normalsize\bfseries}<br />\renewcommand{\cftfigindent}{0pt}<br />\renewcommand{\cftfignumwidth}{4.25em}<br />\renewcommand{\cftfigpresnum}{Figure }<br />\renewcommand{\cftfigaftersnum}{:}<br /><br />\renewcommand{\cfttabfont}{\normalsize\bfseries}<br />\renewcommand{\cfttabindent}{0pt}<br />\renewcommand{\cfttabnumwidth}{4em}<br />\renewcommand{\cfttabpresnum}{Table }<br />\renewcommand{\cfttabaftersnum}{:}<br /><br />\renewcommand{\newline}{\vskip 0.1in}<br /><br />% 	Header and Footer Definitions   %<br /><br />\newcommand\@doctitleshort{}<br />\newcommand{\doctitleshort}[1]{\gdef\@doctitleshort{#1}}<br /><br />\pagestyle{fancy}<br />\fancyhf{}<br />\rhead{\@preparedon}<br />\lfoot{MTConnect \@docnum : \@doctitle { -} Version \@versionnum}<br />\rfoot{\thepage}<br />\renewcommand{\headrulewidth}{0pt}<br /><br />% 	Sections and Enumerate   %<br /><br />\setcounter{secnumdepth}{5}<br />\setcounter{tocdepth}{3}<br /><br />\makeatletter<br />\renewcommand\subparagraph{%<br />	\@startsection {subparagraph}{5}{\z@ }{3.25ex \@plus 1ex<br />	\@minus .2ex}{-1em}{\normalfont \normalsize \bfseries }}%<br />\makeatother<br /><br />\usepackage{float}<br /><br />\restylefloat{figure}<br />\restylefloat{table}<br /><br />\newif\iffigures<br />\newif\iftables<br /><br />\makeatletter<br />\AtEndDocument {%<br />    \if@filesw<br />       \ifnum\value{figure}=\z@ % no figures<br />          \immediate\write\@mainaux {\global\string\figuresfalse}%<br />       \else<br />          \immediate\write\@mainaux {\global\string\figurestrue}%<br />       \fi<br />       \ifnum\value{table}=\z@ % no tables<br />          \immediate\write\@mainaux {\global\string\tablesfalse}%<br />       \else<br />          \immediate\write\@mainaux {\global\string\tablestrue}%<br />       \fi<br />    \fi<br />}<br />\makeatother<br /><br />\definecolor{mtc1}{RGB}{43,105,145}<br />\sectionfont{\bfseries\color{mtc1}\Large}<br />\subsectionfont{\bfseries\color{mtc1}\large}<br />\subsubsectionfont{\bfseries\color{black}\large}<br />\paragraphfont{\bfseries\color{black}\normalsize}<br />\subparagraphfont{\bfseries\color{black}\normalsize}<br /><br />% 	Tables and Figures   %<br /><br />\definecolor{mtc2}{RGB}{0,128,128}<br />\newcommand{\tblh}[1]{\normalsize\textbf{\textcolor{white}{#1}}}<br /><br />\graphicspath{ {./figures/} }<br /><br />\newcommand{\figcap}[1]{\caption{\textbf{#1}}}<br />\captionsetup{labelfont=bf}<br /><br />\newcommand{\tabuheader}{\rowcolor{mtc2}\rowfont[c]{\fontsize{10pt}{12pt}\selectfont\bfseries\color{white}}}<br /><br />% 	Line Numbers   %<br /><br />\renewcommand\linenumberfont{\footnotesize\fontfamily{pcr}\selectfont}<br />\makeatletter<br />\patchcmd{\@startsection}{\@ifstar}{\nolinenumbers\@ifstar}{}{}<br />\patchcmd{\@xsect}{\ignorespaces}{\linenumbers\ignorespaces}{}{}<br />\makeatother<br />\linenumbers<br /><br />% 	Other Commands   %<br /><br />% Courier font selection:<br />\newcommand{\cfont}[1]{{\fontfamily{pcr}\selectfont #1}}<br />\newcommand{\literal}[1]{{\fontfamily{pcr}\selectfont #1}}<br />\newcommand{\xml}[1]{{\fontfamily{pcr}\selectfont #1}}<br />\newcommand{\deprecated}[1]{\sout{#1}}<br />\newcommand{\DEPRECATED}{\textbf{DEPRECATED }}<br />\newcommand{\DEPRECATIONWARNING}{\textbf{DEPRECATION WARNING }}<br />\newcommand{\WARNING}{\textbf{WARNING }}<br /><br />\newcommand{\notesign}{\textsuperscript{\textdagger}}<br />%create a loop if more are required<br /><br />% Requirement levels:<br />\newcommand{\must}{\textbf{MUST }}<br />\newcommand{\mustnot}{\textbf{MUST NOT }}<br />\newcommand{\should}{\textbf{SHOULD }}<br />\newcommand{\shouldnot}{\textbf{SHOULD NOT }}<br />\newcommand{\may}{\textbf{MAY }}<br />\newcommand{\maynot}{\textbf{MAY NOT }}<br />\newcommand{\shall}{\textbf{SHALL }}<br />\newcommand{\shallnot}{\textbf{SHALL NOT }}<br /><br />\newcommand{\NOT}{\textbf{NOT }}<br />% Mapping must, MUST, shall, SHALL to SHALL<br />\newcommand{\MUST}{\must}<br />\newcommand{\MUSTNOT}{\mustnot}<br /><br />\newcommand{\SHOULD}{\should}<br />\newcommand{\SHOULDNOT}{\shouldnot}<br />\newcommand{\MAY}{\may}<br />\newcommand{\MAYNOT}{\maynot}<br />\newcommand{\SHALL}{\shall}<br />\newcommand{\SHALLNOT}{\shallnot}<br /><br />% Formatting for cross-references:<br />\newcommand{\fig}[1]{\textit{Figure~\ref{fig:#1} }}<br />\newcommand{\sect}[1]{\textit{Section~\ref{sec:\detokenize{#1}} - \nameref{\detokenize{sec:#1}}}}<br />\newcommand{\tbl}[1]{\textit{Table~\ref{table:#1}}}<br />\newcommand{\apx}[1]{\textit{Appendix~\ref{appendix:#1}}}<br />\newcommand{\lst}[1]{\textit{Example~\ref{lst:#1}}}<br />\newcommand{\ver}[1]{\textit{MTConnect Version #1 }}<br /><br />% Format for terms<br />\newcommand{\term}[1]{\textit{#1}}<br /><br />% Formatting for code samples:<br />\newcommand{\code}{%<br />\lstset{basicstyle=\footnotesize\fontfamily{pcr}\selectfont,numbers=left,stepnumber=1,xleftmargin=0.25in,breaklines=true}}<br /><br />\definecolor{maroon}{rgb}{0.5,0,0}<br />\definecolor{darkgreen}{rgb}{0,0.5,0}<br /><br />% Glossaries<br /><br />\newglossary*{mtc}{MTConnect Terms}<br />\newglossary*{general}{General Terms}<br />\newglossary*{informationmodel}{Information Model Terms}<br />\newglossary*{protocol}{Protocol Terms}<br />\newglossary*{xml}{XML Terms}<br />\newglossary*{http}{HTTP Terms}<br />\newglossary*{conceptmodel}{Concept Model Terms}<br />\newglossary*{industrial}{Industrial Terms}<br /><br />\makeglossaries<br /><br />%Underlined headings (Example: scenarios in Part5)<br />\newcommand{\ulheading}[1]{\tab \uline{#1}}<br /><br />%indent/tab in tables<br />\newcommand{\tab}{\hspace{0.5cm}}<br /><br />% For acronyms, puts the long description first and then the acronym second.<br />\setabbreviationstyle[acronym]{long-short}<br /><br />\defglsentryfmt[general]{\term{\glsgenentryfmt}}<br />\defglsentryfmt[informationmodel]{\term{\glsgenentryfmt}}<br />\defglsentryfmt[protocol]{\term{\glsgenentryfmt}}<br />\defglsentryfmt[http]{\term{\glsgenentryfmt}}<br />\defglsentryfmt[xml]{\term{\glsgenentryfmt}}<br />\defglsentryfmt[conceptmodel]{\term{\glsgenentryfmt}}<br /><br />\renewcommand{\glsnamefont}[1]{%<br />  \glsifcategory{\glscurrententrylabel}{model}%<br />    {\cfont{#1}}%<br />    {\term{#1}}%<br />}<br /><br />\setglossarystyle{altlist}<br />\makeglossaries<br /><br />% Styles for OPC, UML, SysML <br /><br />\usepackage{sty/tikz-uml}<br />\usetikzlibrary{positioning}<br />\usetikzlibrary{arrows,calc,decorations.markings,math,arrows.meta}<br /><br />\tikzumlset{fill class=white, fill template=white}<br /><br />\tikzstyle{tikzuml unidirectional association style}=%<br />   [color=\tikzumlDefaultDrawColor, {-{Stealth[inset=3pt,scale=2.5,angle'=45]}},%<br />   rounded corners]<br /><br />\tikzstyle{tikzuml inherit style}=%<br />   [color=\tikzumlDefaultDrawColor, {-{Stealth[inset=0pt,scale=2.5,fill=white,angle'=45]}},%<br />   rounded corners]<br /><br />\lstdefinelanguage{XML}<br />{<br />  basicstyle=\ttfamily\footnotesize,<br />  morestring=[b]",<br />  moredelim=[s][\bfseries\color{maroon}]{<}{\ },<br />  moredelim=[s][\bfseries\color{maroon}]{</}{>},<br />  moredelim=[l][\bfseries\color{maroon}]{/>},<br />  moredelim=[l][\bfseries\color{maroon}]{>},<br />  morecomment=[s]{<?}{?>},<br />  morecomment=[s]{<!--}{-->},<br />  commentstyle=\color{darkgreen},<br />  stringstyle=\color{blue},<br />  identifierstyle=\color{red}<br />}<br /><br />\newcommand{\block}[1]{\cfont{#1}}<br />\newcommand{\property}[1]{\cfont{#1}}<br />\newcommand{\operation}[1]{\cfont{#1}}<br /><br />\newenvironment{note}{}{}<br/><br/><br />MTConnect Specification and Materials<br/><i>AMT</i> owns the copyright in this MTConnect Specification or Material. <i>AMT</i> grants to you a non-exclusive, non-transferable, revocable, non-sublicensable, fully-paid-up copyright license to reproduce, copy and redistribute this MTConnect Specification or Material, provided that you may only copy or redistribute the MTConnect Specification or Material in the form in which you received it, without modifications, and with all copyright notices and other notices and disclaimers contained in the MTConnect Specification or Material.<br /><br />If you intend to adopt or implement an MTConnect Specification or Material in a product, whether hardware, software or firmware, which complies with an MTConnect Specification, you shall agree to the MTConnect Specification Implementer License Agreement ("Implementer License") or to the MTConnect Intellectual Property Policy and Agreement ("IP Policy"'). The Implementer License and IP Policy each sets forth the license terms and other terms of use for MTConnect Implementers to adopt or implement the MTConnect Specifications, including certain license rights covering necessary patent claims for that purpose. These materials can be found at <see href="www.MTConnect.org">www.MTConnect.org</see>, or or by contacting <see href="mailto:info@MTConnect.org">mailto:info@MTConnect.org</see>. <br /><br />MTConnect Institute and <i>AMT</i> have no responsibility to identify patents, patent claims or patent applications which may relate to or be required to implement a Specification, or to determine the legal validity or scope of any such patent claims brought to their attention. Each MTConnect Implementer is responsible for securing its own licenses or rights to any patent or other intellectual property rights that may be necessary for such use, and neither <i>AMT</i> nor MTConnect Institute have any obligation to secure any such rights.<br /><br />This Material and all MTConnect Specifications and Materials are provided "as is" and MTConnect Institute and <i>AMT</i>, and each of their respective members, officers, affiliates, sponsors and agents, make no representation or warranty of any kind relating to these materials or to any implementation of the MTConnect Specifications or Materials in any product, including, without limitation, any expressed or implied warranty of noninfringement, merchantability, or fitness for particular purpose, or of the accuracy, reliability, or completeness of information contained herein. In no event shall MTConnect Institute or <i>AMT</i> be liable to any user or implementer of MTConnect Specifications or Materials for the cost of procuring substitute goods or services, lost profits, loss of use, loss of data or any incidental, consequential, indirect, special or punitive damages or other direct damages, whether under contract, tort, warranty or otherwise, arising in any way out of access, use or inability to use the MTConnect Specification or other MTConnect Materials, whether or not they had advance notice of the possibility of such damage.<br /><br />The normative XMI is located at the following URL: [<c>MTConnectSysMLModel.xml</c>](https://model.mtconnect.org/MTConnectSysMLModel.xml)<br /><br/><br/><br />MTConnect References<br/>@manual{MTCPart1,<br />  title = {{MTConnect Standard Part 1.0 - Fundamentals}},<br />  %url = {http://bit.ly/2CaOlt1},<br />  label = {MTConnect Part 1.0},<br />  volume = {Part 1.0},<br />  version = {2.0},<br />  keywords = {MTC}<br />  }<br /><br />@manual{MTCPart2,<br />  title = {{MTConnect Standard: Part 2.0 - Device Information Model}},<br />  %url = {http://bit.ly/2OVfEy6},<br />  label = {MTConnect Part 2.0},<br />  volume = {Part 2.0},<br />  version = {2.0},<br />  keywords = {MTC}<br />  }<br /><br />@manual{MTCPart3,<br />  title = {{MTConnect Standard: Part 3.0 - Observation Information Model}},<br />  %url = {http://bit.ly/2pMob8q},<br />  label = {MTConnect Part 3.0},<br />  volume = {Part 3.0},<br />  version = {2.0},<br />  keywords = {MTC}<br />  }<br /><br />@manual{MTCPart4,<br />  title = {{MTConnect Standard: Part 4.0 - Asset Information Model}},<br />  %url = {http://bit.ly/2yyLc2D},<br />  label = {MTConnect Part 4.0},<br />  volume = {Part 4.0},<br />  version = {2.0},<br />  keywords = {MTC}<br />  }<br /><br />@manual{MTCPart5,<br />  title = {{MTConnect Standard: Part 5.0 - Interface Interaction Model}},<br />  %url = {http://bit.ly/2pPNGFY},<br />  label = {MTConnect Part 5.0},<br />  volume = {Part 5.0},<br />  version = {2.0},<br />  keywords = {MTC}<br />  }<br /><br/><br/><br />External References<br/>@article{Gerkey2004,<br />    title = {{A formal analysis and taxonomy of task allocation in multi-robot systems}},<br />    year = {2004},<br />    journal = {International Journal of Robotics Research},<br />    author = {Gerkey, Brian P. and Matari{\'{c}}, Maja J.},<br />    isbn = {0278-3649},<br />    doi = {10.1177/0278364904045564},<br />    issn = {02783649},<br />    pmid = {13688984},<br />    keywords = {Coordination, Multi-robot systems, Task allocation, Utility}<br />}<br /><br />@book{Gamma1994,<br />    title = {{Design Patterns: Elements of Reusable Object-Oriented Software}},<br />    year = {1994},<br />    author = {Gamma, Erich and Heml, Richard and Johnson, Ralph and Vlissides, John},<br />    pages = {107},<br />    publisher = {Addison Wesley},<br />    isbn = {ISBN 0-201-63361-2}<br />}<br /><br />@article{Birman1987,<br />    title = {{Exploiting virtual synchrony in distributed systems}},<br />    year = {1987},<br />    journal = {ACM SIGOPS Operating Systems Review},<br />    author = {Birman, K. and Joseph, T.},<br />    isbn = {089791242X},<br />    doi = {10.1145/37499.37515},<br />    issn = {01635980},<br />    pmid = {21463384}<br />}<br /><br />@misc{ISO2011,<br />    title = {{ISO/IEC 42010:2011}},<br />    year = {2011},<br />    booktitle = {Systems and software engineering - Architecture description},<br />    author = {{ISO}},<br />    number = {March},<br />    pages = {1--46},<br />    volume = {2011},<br />    url = {http://ieeexplore.ieee.org/xpl/articleDetails.jsp?tp=&arnumber=6129467&contentType=Standards&sortType=asc_p_Sequence&filter=AND(p_Publication_Number:6129465)},<br />    isbn = {978-0-7456-5060-9},<br />    doi = {10.1081/E-ELIS3-120044716},<br />    issn = {10655077},<br />    pmid = {15814772}<br />}<br /><br />@article{ISOInternationalOrganizationforStandardization2011,<br />    title = {{ISO/IEC/IEEE 42010:2011 - Systems and software engineering -- Architecture description}},<br />    year = {2011},<br />    journal = {ISOIECIEEE 420102011E Revision of ISOIEC 420102007 and IEEE Std 14712000},<br />    author = {{ISO (International Organization for Standardization)}},<br />    number = {March},<br />    pages = {1--46},<br />    volume = {2011},<br />    isbn = {VO -},<br />    doi = {10.1109/IEEESTD.2011.6129467},<br />    issn = {0028-0836}<br />}<br /><br />@phdthesis{Fielding2000ArchitecturalArchitectures,<br />    title = {{Architectural Styles and the Design of Network-based Software Architectures}},<br />    year = {2000},<br />    booktitle = {Doctoral thesis},<br />    author = {Fielding, Roy Thomas},<br />    isbn = {0599871180},<br />    doi = {10.1.1.91.2433},<br />    issn = {1098-6596},<br />    pmid = {25246403},<br />    arxivId = {arXiv:1011.1669v3}<br />}<br/><br/><br />Main Template TEX<br/>% 					MTCONNECT DOCUMENT TEMPLATE 							%<br />% 	FILENAME: 		mtconnect.tex											%<br />%	VERSION:		0.1														%<br />% 	DATE:			02/13/2018												%<br />%	PORTED BY:		Moneer Helu												%<br />%	ADDRESS:		Engineering Laboratory									%<br />%					National Institute of Standards and Technology (NIST)	%<br />%					100 Bureau Drive										%<br />%					Mailstop 8260											%<br />%					Gaithersburg, MD 20899									%<br />%					United States of America								%<br />% 	EMAIL:			moneer.helu@nist.gov									%<br />% 	DESCRIPTION:	Template for MTConnect documentation;					%<br />% 					Initial attempt for testing and discussion				%<br />% 	USAGE:			\documentclass[options]{mtconnect}						%<br /><br /><br />\documentclass{mtconnect}	% Load mtconnect document class<br /><br />\input{acronyms.tex}<br />\input{glossary.tex}<br />%\addbibresource{references.bib}<br />\addbibresource{mtc.bib}<br /><br />%\hypersetup{draft} %to test without hyperlinks \hyperref<br />\begin{document}			% Begin document here<br /><br />% REQUIRED INITIAL INPUTS %<br /><br />\docnum{}							% Document "number"<br />\doctitle{}	% Full document title<br />\doctitleshort{}				% Shortened document title<br />\versionnum{}						% MTConnect version<br />\preparedfor{MTConnect Institute}		% Should not change!!!<br />\preparedfrom{\href{https://model.mtconnect.org/MTConnectSysMLModel.xml}{\texttt{MTConnectSysMLModel.xml}}}		% Model link<br />\preparedon{\today}			% Date prepared<br /><br />% FRONT MATTER (DO NOT CHANGE!!!) %<br /><br />\begin{nolinenumbers}<br />\maketitle				% Title page<br /><br />\pagenumbering{roman}<br /><br />% MTConnect Specification and Material Statement:<br />\textbf{\color{mtc1}\Large MTConnect Specification and Materials} \\<br /><br />\input{legal.tex}<br /><br />\clearpage<br />\tableofcontents<br />\thispagestyle{fancy}<br />\clearpage<br />\iffigures<br />   \listoffigures<br />\fi<br />\thispagestyle{fancy}<br />\clearpage<br />\iftables<br />   \listoftables<br />\fi<br />\end{nolinenumbers}<br /><br />\pagenumbering{arabic}<br /><br />% ENTER DOCUMENT CONTENT BELOW %<br /><br />\input{introduction.tex}<br /><br />\input{%MAIN%}<br /><br />\input{profile.tex}<br /><br />\input{appendix.tex}<br /><br />\end{document}<br /><br/><br/><br />Appendix<br/><!-- UNHANDLED MARKDOWN:  --><br /><!-- UNHANDLED MARKDOWN: Appendices --><br />{{addcontentsline{toc}{section}{Appendices}()}}<br />{{renewcommand{\thesubsection}{\Alph{subsection}}()}}<br /><br />## Bibliography<br /><br />Engineering Industries Association. EIA Standard - EIA-274-D, Interchangeable Variable, Block Data Format for Positioning, Contouring, and Contouring/Positioning Numerically Controlled Machines. Washington, D.C. 1979.<br /><br />ISO TC 184/SC4/WG3 N1089. ISO/DIS 10303-238: Industrial automation systems and integration  Product data representation and exchange  Part 238: Application Protocols: Application interpreted model for computerized numerical controllers. Geneva, Switzerland, 2004.<br /><br />International Organization for Standardization. ISO 14649: Industrial automation systems and integration – Physical device control – Data model for computerized numerical controllers – Part 10: General process data. Geneva, Switzerland, 2004.<br /><br />International Organization for Standardization. ISO 14649: Industrial automation systems and integration – Physical device control – Data model for computerized numerical controllers – Part 11: Process data for milling. Geneva, Switzerland, 2000.<br /><br />International Organization for Standardization. ISO 6983/1 – Numerical Control of machines – Program format and definition of address words – Part 1: Data format for positioning, line and contouring control systems. Geneva, Switzerland, 1982.<br /><br />Electronic Industries Association. ANSI/EIA-494-B-1992, 32 Bit Binary CL (BCL) and 7 Bit ASCII CL (ACL) Exchange Input Format for Numerically Controlled Machines. Washington, D.C. 1992.<br /><br />National Aerospace Standard. Uniform Cutting Tests - NAS Series: Metal Cutting Equipment Specifications. Washington, D.C. 1969.<br /><br />International Organization for Standardization. ISO 10303-11: 1994, Industrial automation systems and integration  Product data representation and exchange  Part 11: Description methods: The EXPRESS language reference manual. Geneva, Switzerland, 1994.<br /><br />International Organization for Standardization. ISO 10303-21: 1996, Industrial automation systems and integration -- Product data representation and exchange -- Part 21: Implementation methods: Clear text encoding of the exchange structure. Geneva, Switzerland, 1996.<br /><br />H.L. Horton, F.D. Jones, and E. Oberg. Machinery's Handbook. Industrial Press, Inc. New York, 1984.<br /><br />International Organization for Standardization. ISO 841-2001: Industrial automation systems and integration - Numerical control of machines - Coordinate systems and motion nomenclature. Geneva, Switzerland, 2001.<br /><br />ASME B5.57: Methods for Performance Evaluation of Computer Numerically Controlled Lathes and Turning Centers, 1998.<br /><br />ASME/ANSI B5.54: Methods for Performance Evaluation of Computer Numerically Controlled Machining Centers. 2005.<br /><br />OPC Foundation. OPC Unified Architecture Specification, Part 1: Concepts Version 1.00. July 28, 2006.<br /><br />IEEE STD 1451.0-2007, Standard for a Smart Transducer Interface for Sensors and Actuators – Common Functions, Communication Protocols, and Transducer Electronic Data Sheet (TEDS) Formats, IEEE Instrumentation and Measurement Society, TC-9, The Institute of Electrical and Electronics Engineers, Inc., New York, N.Y. 10016, SH99684, October 5, 2007.<br /><br />IEEE STD 1451.4-1994, Standard for a Smart Transducer Interface for Sensors and Actuators – Mixed-Mode Communication Protocols and Transducer Electronic Data Sheet (TEDS) Formats, IEEE Instrumentation and Measurement Society, TC-9, The Institute of Electrical and Electronics Engineers, Inc., New York, N.Y. 10016, SH95225, December 15, 2004. <br/><br/><br />Main Template MD<br/># MTConnect Specification and Material Statement<br /><br />{{input(legal.md)}}<br /><br />{{input(introduction.md)}}<br /><br />{{input(%MAIN%)}}<br /><br />{{input(profile.md)}}<br /><br />{{input(appendix.md)}}<br/><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1596108922525_351463_147">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class CommonDocumentsPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1596108922525_351463_147";
		
		/// <inheritdoc />
		public string Name => "Common Documents";

		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;Acronyms&#10;&#10;&#10;&#10;
{{newacronym{API}{API}{application programming interface}()}}
{{newacronym{BOM}{BOM}{bill of materials}()}}
{{newacronym{DER}{DER}{designated-engineering representative}()}}
{{newacronym{DMC}{DMC}{digital manufacturing certificate}()}}
{{newacronym{SME}{SME}{small-to-medium enterprise}()}}
{{newacronym{URI}{URI}{Uniform Resource Identifier}()}}
{{newacronym{URL}{URL}{Uniform Resource Locator}()}}
{{newacronym{URN}{URN}{Uniform Resource Name}()}}
{{newacronym{UTC}{UTC}{Coordinated Universal Time}()}}


{{newacronym{2D}{2D}{two-dimensional}()}}
{{newacronym{3D}{3D}{three-dimensional}()}}
{{newacronym{AI}{AI}{artificial intelligence}()}}
{{newacronym{ALM}{ALM}{application lifecycle management}()}}
{{newacronym{AMT}{AMT}{The Association for Manufacturing Technology}()}}
{{newacronym{ANSI}{ANSI}{American National Standards Institute}()}}
{{newacronym{AP}{AP}{Application Protocol}()}}
{{newacronym{ASME}{ASME}{American Society of Mechanical Engineers}()}}
{{newacronym{ASTM}{ASTM}{American Society for Testing and Materials}()}}
{{newacronym{AWS}{AWS}{American Welding Society}()}}
{{newacronym{BDD}{BDD}{block definition diagram}()}}
{{newacronym{BST}{BST}{Board on Standardization and Testing}()}}
{{newacronym{CA}{CA}{certificate authority}()}}
{{newacronym{CAD}{CAD}{computer-aided design}()}}
{{newacronym{CAE}{CAE}{computer-aided engineering}()}}
{{newacronym{CAI}{CAI}{computer-aided inspection}()}}
{{newacronym{CAM}{CAM}{computer-aided manufacturing}()}}
{{newacronym{CAx}{CAx}{computer-aided technologies}()}}
{{newacronym{CFD}{CFD}{computational fluid dynamics}()}}
{{newacronym{CM}{CM}{configuration management}()}}
{{newacronym{CMS}{CMS}{coordinate-measurement system}()}}
{{newacronym{CNRI}{CNRI}{Corporation for National Research Initiatives}()}}
{{newacronym{CPM}{CPM}{Core Product Model}()}}
{{newacronym{CPM2}{CPM2}{Revised Core Product Model}()}}
{{newacronym{CPSC}{CPSC}{Consumer Product Safety Commission}()}}
{{newacronym{C&R}{C\\&R}{cause and remedy}()}}
{{newacronym{cUAV}{cUAV}{configurable unmanned aerial vehicle}()}}
{{newacronym{DARPA}{DARPA}{Defense Advanced Research Projects Agency}()}}
{{newacronym{DFM}{DFM}{design for manufacturing}()}}
{{newacronym{DLA}{DLA}{Defense Logistics Agency}()}}
{{newacronym{DMSC}{DMSC}{Dimensional Metrology Standards Consortium}()}}
{{newacronym{DNS}{DNS}{Domain Name System}()}}
{{newacronym{DoD}{DoD}{U.S. Department of Defense}()}}
{{newacronym{DOI}{DOI}{Distributed Object Identifier}()}}
{{newacronym{DRM}{DRM}{digital rights management}()}}
{{newacronym{ECR}{ECR}{engineering change request}()}}
{{newacronym{ERP}{ERP}{enterprise resource planning}()}}
{{newacronym{FAA}{FAA}{Federal Aviation Administration}()}}
{{newacronym{FAIR}{FAIR}{first article inspection reporting}()}}
{{newacronym{FDA}{FDA}{Food and Drug Administration}()}}
{{newacronym{FEA}{FEA}{finite-element analysis}()}}
{{newacronym{GD&T}{GD\\&T}{geometric dimensions and tolerances}()}}
{{newacronym{GID}{GID}{global identifier}()}}
{{newacronym{HTML}{HTML}{Hypertext Markup Language}()}}
{{newacronym{HTTP}{HTTP}{Hypertext Transfer Protocol}()}}
{{newacronym{HTTPS}{HTTPS}{Hypertext Transfer Protocol over Secure Sockets Layer}()}}
{{newacronym{ID}{ID}{identifier}()}}
{{newacronym{IEEE}{IEEE}{Institute of Electrical and Electronics Engineers}()}}
{{newacronym{IIoT}{IIoT}{industrial internet of things}()}}
{{newacronym{INCOSE}{INCOSE}{International Council on Systems Engineering}()}}
{{newacronym{I/O}{I/O}{in-out}()}}
{{newacronym{IP}{IP}{intellectual property}()}}
{{newacronym{ISO}{ISO}{International Standards Organization}()}}
{{newacronym{ISS}{ISS}{International Space Station}()}}
{{newacronym{IT}{IT}{information technology}()}}
{{newacronym{ITU-T}{ITU-T}{Telecommunication Standardization Sector of the International Telecommunication Union}()}}
{{newacronym{JSON}{JSON}{JavaScript Object Notation}()}}
{{newacronym{JT}{JT}{Jupiter Tesselation}()}}
{{newacronym{LHS}{LHS}{Lifecycle Handler System}()}}
{{newacronym{LIFT}{LIFT}{Lifecycle Information Framework and Technology}()}}
{{newacronym{LOI}{LOI}{Lifecycle Object Identifier}()}}
{{newacronym{MAC}{MAC}{media access control}()}}
{{newacronym{MADE}{MADE}{Manufacturing Automation and Design Engineering}()}}
{{newacronym{MBD}{MBD}{model-based definition}()}}
{{newacronym{MBE}{MBE}{Model-Based Enterprise}()}}
{{newacronym{MBI}{MBI}{model-based inspection}()}}
{{newacronym{MBM}{MBM}{model-based manufacturing}()}}
{{newacronym{MBSD}{MBSD}{model-based standards development}()}}
{{newacronym{MBSE}{MBSE}{model-based systems engineering}()}}
{{newacronym{MEDALS}{MEDALS}{Military Engineering Data Asset Locator System}()}}
{{newacronym{MES}{MES}{manufacturing execution system}()}}
{{newacronym{MOI}{MOI}{manufacturing object identifier}()}}
{{newacronym{MTC}{MTC}{Manufacturing Technology Centre}()}}
{{newacronym{NASA}{NASA}{National Aeronautics and Space Administration}()}}
{{newacronym{NC}{NC}{numerical control}()}}
{{newacronym{NIST}{NIST}{National Institute of Standards and Technology}()}}
{{newacronym{NNMI}{NNMI}{National Network of Manufacturing Innovation}()}}
{{newacronym{NSF}{NSF}{National Science Foundation}()}}
{{newacronym{NTSC}{NTSC}{National Transportation Safety Board}()}}
{{newacronym{OASIS}{OASIS}{Organization for the Advancement of Structured Information Standards}()}}
{{newacronym{ODI}{ODI}{Open Data Institute}()}}
{{newacronym{OEM}{OEM}{original equipment manufacturer}()}}
{{newacronym{OOI}{OOI}{Ocean Observatories Initiative}()}}
{{newacronym{OSLC}{OSLC}{Open Services for Lifecycle Collaboration}()}}
{{newacronym{OSTP}{OSTP}{Office of Science and Technology Policy}()}}
{{newacronym{OT}{OT}{operational technology}()}}
{{newacronym{OWL}{OWL}{Ontology Web Language}()}}
{{newacronym{PDF}{PDF}{Portable Document Format}()}}
{{newacronym{PDM}{PDM}{product-data management}()}}
{{newacronym{PDQ}{PDQ}{product-data quality}()}}
{{newacronym{PHM}{PHM}{prognosis and health monitoring}()}}
{{newacronym{PI}{PI}{principal investigator}()}}
{{newacronym{PLCS}{PLCS}{Product Life Cycle Support}()}}
{{newacronym{PLM}{PLM}{product lifecycle management}()}}
{{newacronym{PLOT}{PLOT}{product lifecycle of trust}()}}
{{newacronym{PMI}{PMI}{product and manufacturing information}()}}
{{newacronym{PRC}{PRC}{Product Representation Compact}()}}
{{newacronym{PSI}{PSI}{Physical Science Informatics}()}}
{{newacronym{PTAB}{PTAB}{Primary Trustworthy Digital Repository Authorization Body Ltd.}()}}
{{newacronym{QIF}{QIF}{Quality Information Framework}()}}
{{newacronym{QMS}{QMS}{quality management system}()}}
{{newacronym{RDF}{RDF}{Resource Description Framework}()}}
{{newacronym{REST}{REST}{Representational State Transfer}()}}
{{newacronym{RII}{RII}{receiving and incoming inspection}()}}
{{newacronym{SaaS}{SaaS}{software-as-a-service}()}}
{{newacronym{SAML}{SAML}{Security Assertion Markup Language}()}}
{{newacronym{SC}{SC}{Standards Committee}()}}
{{newacronym{SDO}{SDO}{Standards Development Organization}()}}
{{newacronym{SFTP}{SFTP}{Secure File Transfer Protocol}()}}
{{newacronym{SKOS}{SKOS}{Simple Knowledge Organization System}()}}
{{newacronym{SLH}{SLH}{system lifecycle handler}()}}
{{newacronym{SLR}{SLR}{systematic literature review}()}}
{{newacronym{S/MIME}{S/MIME}{Secure/Multipurpose Internet Mail Extensions}()}}
{{newacronym{SMOPAC}{SMOPAC}{Smart Manufacturing Operations Planning and Control}()}}
{{newacronym{sms}{SMS Test Bed}{Smart Manufacturing Systems Test Bed}()}}
{{newacronym{SOA}{SOA}{service-oriented architecture}()}}
{{newacronym{SPMM}{SPMM}{semantic-based product metamodel}()}}
{{newacronym{SSL}{SSL}{Secure Sockets Layer}()}}
{{newacronym{STEP}{STEP}{Standard for the Exchange of Product Model Data}()}}
{{newacronym{STEP AP242}{STEP AP242}{Standard for the Exchange of Product Model Data Application Protocol 242}()}}
{{newacronym{STL}{STL}{Stereolithography}()}}
{{newacronym{SysML}{SysML}{Systems Modeling Language}()}}
{{newacronym{TDP}{TDP}{technical data package}()}}
{{newacronym{TLS}{TLS}{Transport Layer Security}()}}
{{newacronym{TSM}{TSM}{Total System Model}()}}
{{newacronym{UML}{UML}{Unified Modeling Language}()}}
{{newacronym{UUID}{UUID}{Universally Unique Identifier}()}}
{{newacronym{V&V}{V\\&V}{verification and validation}()}}
{{newacronym{W3C}{W3C}{World Wide Web Consortium}()}}
{{newacronym{WSN}{WSN}{Wirth Syntax Notation}()}}
{{newacronym{WWW}{WWW}{World Wide Web}()}}
{{newacronym{XML}{XML}{Extensible Markup Language}()}}
{{newacronym{X.509-PKI}{X.509-PKI}{Public Key Infrastructure}()}}
{{newacronym{X.509-PMI}{X.509-PMI}{Privilege Management Infrastructure}()}}
{{newacronym{XSD}{XSD}{XML Schema Definitions}()}}

{{newacronym{OPC}{OPC}{OLE for Process Control}()}}
{{newacronym{UA}{UA}{Unified Architecture}()}}
{{newacronym{UAL}{UAL}{Unified Architecture Language}()}}
{{newacronym{HMI}{HMI}{Human Machine Interface}()}}
{{newacronym{PLC}{PLC}{Programmable Logic Controller}()}}
{{newacronym{SCADA}{SCADA}{Supervisory Control And Data Acquisition}()}}
{{newacronym{TCP/IP}{TCP/IP}{Transmission Control Protocol/Internet Protocol}()}}
{{newacronym{CNC}{CNC}{Computer Numerical Controller}()}}


{{newacronym{MOM}{MOM}{Message Orienged Middleware}()}}
{{newacronym{PMS}{PMS}{Production Management System}()}}
{{newacronym{ISV}{ISV}{Independent Software Vendor}()}}
{{newacronym{MQTT}{MQTT}{Message Queuing Telemetry Transport}()}}
{{newacronym{CDATA}{CDATA}{Character Data}()}}
{{newacronym{NMTOKEN}{NMTOKEN}{Name Token}()}}
{{newacronym{QName}{QName}{Qualified Name}()}}
{{newacronym{XPath}{XPath}{XML Path Language}()}}
&#10;
&#10;&#10;&#10;MTConnect Class&#10;&#10;&#10;&#10;%   MTConnect Document Class    %

\\NeedsTeXFormat{LaTeX2e}
\\ProvidesClass{mtconnect}[2018/02/13 LaTeX document class for MTConnect]

%   Preliminary Declarations    %

\\LoadClass[12pt,letterpaper,twoside]{article}
\\usepackage[utf8]{inputenc}
\\usepackage[letterpaper,top=1.25in,%
            bottom=1.25in,footskip=0.5in]{geometry}

\\usepackage[citations,hybrid,smartEllipses,hashEnumerators,html,%
           pipeTables,tableCaptions,fencedCode,codeSpans,tightLists=false,%
           cacheDir=markdowncache]{markdown}%
\\usepackage[absolute]{textpos}
\\RequirePackage[htt]{hyphenat}				% Allow hyphenation of fixed space fonts
\\RequirePackage{fancyvrb}
\\RequirePackage{placeins}
\\RequirePackage{booktabs}
\\usepackage{morewrites}
\\RequirePackage{times}					% Loads Adobe Times Roman Font (clone of Times New Roman)
\\RequirePackage{mathptmx}				% Loads Adobe Times Roman Math Font
\\RequirePackage{ifpdf}					% Enables switch between latex and pdflatex
\\RequirePackage{stringstrings}			% Loads stringstrings to create Camel and Pascal case fonts
\\RequirePackage{ifthen}					% Loads ifthen package for conditional statements
\\RequirePackage[T1]{fontenc}			% Loads fontenc package for controlled vocabulary formatting
\\let\\BreakableUnderscore\\undefined
\\RequirePackage{graphicx}				% Loads graphicx package to include figures and images
\\RequirePackage{fancyhdr}				% Loads fancyhdr package to modify headers and footers
%\\RequirePackage[hyphens]{url}					% Loads url package to typeset URLs
\\RequirePackage{lineno}					% Loads lineno package to apply line numbers to document
\\RequirePackage{etoolbox}				% Loads etoolbox package to patch lineno package and suppress line numbers in section headings
\\RequirePackage{sectsty}				% Loads sectsty package to modify font of section headings
\\RequirePackage{xcolor}					% Loads xcolor package to define color for fonts and tables
\\RequirePackage{colortbl}				% Loads colortbl package to provide colors for table shading
\\RequirePackage{caption}				% Loads caption package to adjust caption font
\\usepackage{listings}				% Loads listings package to typeset code samples
\\lstset{ %default
    basicstyle=\\footnotesize\\fontfamily{pcr}\\selectfont,
    numbers=left,
    stepnumber=1,
    xleftmargin=0.25in,
	breaklines=true
}
\\renewcommand\\lstlistingname{Example}
\\RequirePackage{hyperref}				% Loads hyperref package to link TOC/LOF/LOT
\\RequirePackage{tocloft}				% Loads tocloft package to format TOC/LOF/LOT
\\RequirePackage[ampersand]{easylist}	% Loads easylist package to simplify lists using &
\\RequirePackage[english]{babel}
\\RequirePackage{csquotes}
\\RequirePackage{xstring}
\\RequirePackage{siunitx}
\\RequirePackage{upgreek}
\\RequirePackage{longtable}
\\RequirePackage{enumitem}
\\usepackage{tabularray}
\\usepackage{amsmath}
\\usepackage{amssymb}
\\usepackage[normalem]{ulem} %For deprecated items
\\RequirePackage[acronym,toc,numberedsection,%
  abbreviations,automake,nonumberlist,%
  section=subsection]{glossaries-extra}
\\usepackage{mdframed}
\\usepackage{nameref}
\\usepackage[titletoc,title]{appendix}
\\usepackage{hanging}
\\usepackage{titlesec}
\\usepackage{xargs}
\\newcommand{\\sectionbreak}{\\clearpage}

\\usepackage[backend=biber,style=alphabetic,]{biblatex}
\\defbibheading{bibliography}[\\bibname]{%
  \\subsection{#1}}

\\usepackage{titlesec}

%   Watermark   %

%\\usepackage{background}
%\\backgroundsetup{contents=DRAFT, opacity=0.3, color=cyan, scale=9}

% Formatting for MTConnect with registration mark, which is required in title and footer. 
\\newcommand{\\mtconnectregistered}{MTConnect\\textsuperscript{\\textregistered} }
% Formatting for MTConnect without registration mark, which can be used everywhere except title page(s) and footer. 
%\\newcommand{\\mtconnect}{MTConnect } %Use MTConnect

\\newcommand{\\storedstringPCR}[1]{{\\fontfamily{pcr}\\selectfont #1}}

%    Page Layout    %

\\setlength\\paperheight{11in}
\\setlength\\paperwidth{8.5in}
\\setlength\\oddsidemargin{0.25in}
\\setlength\\evensidemargin{0.25in}

\\setlength\\parindent{0pt}
\\setlength\\parskip{1em}

%   Title Page  %

\\newcommand\\@docnum{}
\\newcommand\\@doctitle{}
\\newcommand\\@versionnum{}
\\newcommand\\@preparedfor{}
\\newcommand\\@preparedby{}
\\newcommand\\@preparedon{}
\\newcommand\\@preparedfrom{}
\\newcommand{\\docnum}[1]{\\gdef\\@docnum{#1}}
\\newcommand{\\doctitle}[1]{\\gdef\\@doctitle{#1}}
\\newcommand{\\versionnum}[1]{\\gdef\\@versionnum{#1}}
\\newcommand{\\preparedfor}[1]{\\gdef\\@preparedfor{#1}}
\\newcommand{\\preparedby}[1]{\\gdef\\@preparedby{#1}}
\\newcommand{\\preparedon}[1]{\\gdef\\@preparedon{#1}}
\\newcommand{\\preparedfrom}[1]{\\gdef\\@preparedfrom{#1}}

\\renewcommand{\\maketitle}{%
	\\begin{titlepage}%
    	\\begin{flushleft}%
        	\\includegraphics[width=0.5\\linewidth]{mtconnect.png} \\\\%
        \\end{flushleft}%
        \\vfill%
        \\begin{center}%
        	\\Huge{\\textbf{\\mtconnectregistered Standard}} \\\\%
            \\huge{\\@docnum\\ -- \\@doctitle} \\\\%
            \\LARGE{Version \\@versionnum} \\\\%
        \\end{center}%
        \\vfill%
        \\hspace*{\\fill}%
		\\begin{tabular}[t]{l@{}}%
			Prepared for: \\@preparedfor \\\\%
			Prepared from: \\@preparedfrom \\\\%
        	Prepared on: \\@preparedon \\\\%
		\\end{tabular}%
		\\vfill%
		\\noindent \\footnotesize{\\mtconnectregistered is a registered trademark of AMT - The Association for Manufacturing Technology. Use of MTConnect is limited to use as specified on \\url{http://www.mtconnect.org/}.}%
    \\end{titlepage}%
    \\setcounter{page}{1}%
}

%   Table of Contents/Figures/Tables    %

\\addto\\captionsenglish{%
\\renewcommand\\contentsname{\\color{mtc1} Table of Contents}}
\\addto\\captionsenglish{%
\\renewcommand\\listfigurename{\\color{mtc1} Table of Figures}}
\\addto\\captionsenglish{%
\\renewcommand\\listtablename{\\color{mtc1} List of Tables}}

\\renewcommand{\\cftfigfont}{\\normalsize\\bfseries}
\\renewcommand{\\cftfigindent}{0pt}
\\renewcommand{\\cftfignumwidth}{4.25em}
\\renewcommand{\\cftfigpresnum}{Figure }
\\renewcommand{\\cftfigaftersnum}{:}

\\renewcommand{\\cfttabfont}{\\normalsize\\bfseries}
\\renewcommand{\\cfttabindent}{0pt}
\\renewcommand{\\cfttabnumwidth}{4em}
\\renewcommand{\\cfttabpresnum}{Table }
\\renewcommand{\\cfttabaftersnum}{:}

\\renewcommand{\\newline}{\\vskip 0.1in}

% 	Header and Footer Definitions   %

\\newcommand\\@doctitleshort{}
\\newcommand{\\doctitleshort}[1]{\\gdef\\@doctitleshort{#1}}

\\pagestyle{fancy}
\\fancyhf{}
\\rhead{\\@preparedon}
\\lfoot{MTConnect \\@docnum : \\@doctitle { -} Version \\@versionnum}
\\rfoot{\\thepage}
\\renewcommand{\\headrulewidth}{0pt}

% 	Sections and Enumerate   %

\\setcounter{secnumdepth}{5}
\\setcounter{tocdepth}{3}

\\makeatletter
\\renewcommand\\subparagraph{%
	\\@startsection {subparagraph}{5}{\\z@ }{3.25ex \\@plus 1ex
	\\@minus .2ex}{-1em}{\\normalfont \\normalsize \\bfseries }}%
\\makeatother

\\usepackage{float}

\\restylefloat{figure}
\\restylefloat{table}

\\newif\\iffigures
\\newif\\iftables

\\makeatletter
\\AtEndDocument {%
    \\if@filesw
       \\ifnum\\value{figure}=\\z@ % no figures
          \\immediate\\write\\@mainaux {\\global\\string\\figuresfalse}%
       \\else
          \\immediate\\write\\@mainaux {\\global\\string\\figurestrue}%
       \\fi
       \\ifnum\\value{table}=\\z@ % no tables
          \\immediate\\write\\@mainaux {\\global\\string\\tablesfalse}%
       \\else
          \\immediate\\write\\@mainaux {\\global\\string\\tablestrue}%
       \\fi
    \\fi
}
\\makeatother

\\definecolor{mtc1}{RGB}{43,105,145}
\\sectionfont{\\bfseries\\color{mtc1}\\Large}
\\subsectionfont{\\bfseries\\color{mtc1}\\large}
\\subsubsectionfont{\\bfseries\\color{black}\\large}
\\paragraphfont{\\bfseries\\color{black}\\normalsize}
\\subparagraphfont{\\bfseries\\color{black}\\normalsize}

% 	Tables and Figures   %

\\definecolor{mtc2}{RGB}{0,128,128}
\\newcommand{\\tblh}[1]{\\normalsize\\textbf{\\textcolor{white}{#1}}}

\\graphicspath{ {./figures/} }

\\newcommand{\\figcap}[1]{\\caption{\\textbf{#1}}}
\\captionsetup{labelfont=bf}

\\newcommand{\\tabuheader}{\\rowcolor{mtc2}\\rowfont[c]{\\fontsize{10pt}{12pt}\\selectfont\\bfseries\\color{white}}}

% 	Line Numbers   %

\\renewcommand\\linenumberfont{\\footnotesize\\fontfamily{pcr}\\selectfont}
\\makeatletter
\\patchcmd{\\@startsection}{\\@ifstar}{\\nolinenumbers\\@ifstar}{}{}
\\patchcmd{\\@xsect}{\\ignorespaces}{\\linenumbers\\ignorespaces}{}{}
\\makeatother
\\linenumbers

% 	Other Commands   %

% Courier font selection:
\\newcommand{\\cfont}[1]{{\\fontfamily{pcr}\\selectfont #1}}
\\newcommand{\\literal}[1]{{\\fontfamily{pcr}\\selectfont #1}}
\\newcommand{\\xml}[1]{{\\fontfamily{pcr}\\selectfont #1}}
\\newcommand{\\deprecated}[1]{\\sout{#1}}
\\newcommand{\\DEPRECATED}{\\textbf{DEPRECATED }}
\\newcommand{\\DEPRECATIONWARNING}{\\textbf{DEPRECATION WARNING }}
\\newcommand{\\WARNING}{\\textbf{WARNING }}

\\newcommand{\\notesign}{\\textsuperscript{\\textdagger}}
%create a loop if more are required

% Requirement levels:
\\newcommand{\\must}{\\textbf{MUST }}
\\newcommand{\\mustnot}{\\textbf{MUST NOT }}
\\newcommand{\\should}{\\textbf{SHOULD }}
\\newcommand{\\shouldnot}{\\textbf{SHOULD NOT }}
\\newcommand{\\may}{\\textbf{MAY }}
\\newcommand{\\maynot}{\\textbf{MAY NOT }}
\\newcommand{\\shall}{\\textbf{SHALL }}
\\newcommand{\\shallnot}{\\textbf{SHALL NOT }}

\\newcommand{\\NOT}{\\textbf{NOT }}
% Mapping must, MUST, shall, SHALL to SHALL
\\newcommand{\\MUST}{\\must}
\\newcommand{\\MUSTNOT}{\\mustnot}

\\newcommand{\\SHOULD}{\\should}
\\newcommand{\\SHOULDNOT}{\\shouldnot}
\\newcommand{\\MAY}{\\may}
\\newcommand{\\MAYNOT}{\\maynot}
\\newcommand{\\SHALL}{\\shall}
\\newcommand{\\SHALLNOT}{\\shallnot}

% Formatting for cross-references:
\\newcommand{\\fig}[1]{\\textit{Figure~\\ref{fig:#1} }}
\\newcommand{\\sect}[1]{\\textit{Section~\\ref{sec:\\detokenize{#1}} - \\nameref{\\detokenize{sec:#1}}}}
\\newcommand{\\tbl}[1]{\\textit{Table~\\ref{table:#1}}}
\\newcommand{\\apx}[1]{\\textit{Appendix~\\ref{appendix:#1}}}
\\newcommand{\\lst}[1]{\\textit{Example~\\ref{lst:#1}}}
\\newcommand{\\ver}[1]{\\textit{MTConnect Version #1 }}

% Format for terms
\\newcommand{\\term}[1]{\\textit{#1}}

% Formatting for code samples:
\\newcommand{\\code}{%
\\lstset{basicstyle=\\footnotesize\\fontfamily{pcr}\\selectfont,numbers=left,stepnumber=1,xleftmargin=0.25in,breaklines=true}}

\\definecolor{maroon}{rgb}{0.5,0,0}
\\definecolor{darkgreen}{rgb}{0,0.5,0}

% Glossaries

\\newglossary*{mtc}{MTConnect Terms}
\\newglossary*{general}{General Terms}
\\newglossary*{informationmodel}{Information Model Terms}
\\newglossary*{protocol}{Protocol Terms}
\\newglossary*{xml}{XML Terms}
\\newglossary*{http}{HTTP Terms}
\\newglossary*{conceptmodel}{Concept Model Terms}
\\newglossary*{industrial}{Industrial Terms}

\\makeglossaries

%Underlined headings (Example: scenarios in Part5)
\\newcommand{\\ulheading}[1]{\\tab \\uline{#1}}

%indent/tab in tables
\\newcommand{\\tab}{\\hspace{0.5cm}}

% For acronyms, puts the long description first and then the acronym second.
\\setabbreviationstyle[acronym]{long-short}

\\defglsentryfmt[general]{\\term{\\glsgenentryfmt}}
\\defglsentryfmt[informationmodel]{\\term{\\glsgenentryfmt}}
\\defglsentryfmt[protocol]{\\term{\\glsgenentryfmt}}
\\defglsentryfmt[http]{\\term{\\glsgenentryfmt}}
\\defglsentryfmt[xml]{\\term{\\glsgenentryfmt}}
\\defglsentryfmt[conceptmodel]{\\term{\\glsgenentryfmt}}

\\renewcommand{\\glsnamefont}[1]{%
  \\glsifcategory{\\glscurrententrylabel}{model}%
    {\\cfont{#1}}%
    {\\term{#1}}%
}

\\setglossarystyle{altlist}
\\makeglossaries

% Styles for OPC, UML, SysML 

\\usepackage{sty/tikz-uml}
\\usetikzlibrary{positioning}
\\usetikzlibrary{arrows,calc,decorations.markings,math,arrows.meta}

\\tikzumlset{fill class=white, fill template=white}

\\tikzstyle{tikzuml unidirectional association style}=%
   [color=\\tikzumlDefaultDrawColor, {-{Stealth[inset=3pt,scale=2.5,angle'=45]}},%
   rounded corners]

\\tikzstyle{tikzuml inherit style}=%
   [color=\\tikzumlDefaultDrawColor, {-{Stealth[inset=0pt,scale=2.5,fill=white,angle'=45]}},%
   rounded corners]

\\lstdefinelanguage{XML}
{
  basicstyle=\\ttfamily\\footnotesize,
  morestring=[b]"",
  moredelim=[s][\\bfseries\\color{maroon}]{<}{\\ },
  moredelim=[s][\\bfseries\\color{maroon}]{</}{>},
  moredelim=[l][\\bfseries\\color{maroon}]{/>},
  moredelim=[l][\\bfseries\\color{maroon}]{>},
  morecomment=[s]{<?}{?>},
  morecomment=[s]{<!--}{-->},
  commentstyle=\\color{darkgreen},
  stringstyle=\\color{blue},
  identifierstyle=\\color{red}
}

\\newcommand{\\block}[1]{\\cfont{#1}}
\\newcommand{\\property}[1]{\\cfont{#1}}
\\newcommand{\\operation}[1]{\\cfont{#1}}

\\newenvironment{note}{}{}&#10;
&#10;&#10;&#10;MTConnect Specification and Materials&#10;&#10;&#10;&#10;{{term(AMT)}} owns the copyright in this MTConnect Specification or Material. {{term(AMT)}} grants to you a non-exclusive, non-transferable, revocable, non-sublicensable, fully-paid-up copyright license to reproduce, copy and redistribute this MTConnect Specification or Material, provided that you may only copy or redistribute the MTConnect Specification or Material in the form in which you received it, without modifications, and with all copyright notices and other notices and disclaimers contained in the MTConnect Specification or Material.

If you intend to adopt or implement an MTConnect Specification or Material in a product, whether hardware, software or firmware, which complies with an MTConnect Specification, you shall agree to the MTConnect Specification Implementer License Agreement (""Implementer License"") or to the MTConnect Intellectual Property Policy and Agreement (""IP Policy""'). The Implementer License and IP Policy each sets forth the license terms and other terms of use for MTConnect Implementers to adopt or implement the MTConnect Specifications, including certain license rights covering necessary patent claims for that purpose. These materials can be found at {{url(www.MTConnect.org)}}, or or by contacting {{url(mailto:info@MTConnect.org)}}. 

MTConnect Institute and {{term(AMT)}} have no responsibility to identify patents, patent claims or patent applications which may relate to or be required to implement a Specification, or to determine the legal validity or scope of any such patent claims brought to their attention. Each MTConnect Implementer is responsible for securing its own licenses or rights to any patent or other intellectual property rights that may be necessary for such use, and neither {{term(AMT)}} nor MTConnect Institute have any obligation to secure any such rights.

This Material and all MTConnect Specifications and Materials are provided ""as is"" and MTConnect Institute and {{term(AMT)}}, and each of their respective members, officers, affiliates, sponsors and agents, make no representation or warranty of any kind relating to these materials or to any implementation of the MTConnect Specifications or Materials in any product, including, without limitation, any expressed or implied warranty of noninfringement, merchantability, or fitness for particular purpose, or of the accuracy, reliability, or completeness of information contained herein. In no event shall MTConnect Institute or {{term(AMT)}} be liable to any user or implementer of MTConnect Specifications or Materials for the cost of procuring substitute goods or services, lost profits, loss of use, loss of data or any incidental, consequential, indirect, special or punitive damages or other direct damages, whether under contract, tort, warranty or otherwise, arising in any way out of access, use or inability to use the MTConnect Specification or other MTConnect Materials, whether or not they had advance notice of the possibility of such damage.

The normative XMI is located at the following URL: [`MTConnectSysMLModel.xml`](https://model.mtconnect.org/MTConnectSysMLModel.xml)
&#10;
&#10;&#10;&#10;MTConnect References&#10;&#10;&#10;&#10;@manual{MTCPart1,
  title = {{MTConnect Standard Part 1.0 - Fundamentals}},
  %url = {http://bit.ly/2CaOlt1},
  label = {MTConnect Part 1.0},
  volume = {Part 1.0},
  version = {2.0},
  keywords = {MTC}
  }

@manual{MTCPart2,
  title = {{MTConnect Standard: Part 2.0 - Device Information Model}},
  %url = {http://bit.ly/2OVfEy6},
  label = {MTConnect Part 2.0},
  volume = {Part 2.0},
  version = {2.0},
  keywords = {MTC}
  }

@manual{MTCPart3,
  title = {{MTConnect Standard: Part 3.0 - Observation Information Model}},
  %url = {http://bit.ly/2pMob8q},
  label = {MTConnect Part 3.0},
  volume = {Part 3.0},
  version = {2.0},
  keywords = {MTC}
  }

@manual{MTCPart4,
  title = {{MTConnect Standard: Part 4.0 - Asset Information Model}},
  %url = {http://bit.ly/2yyLc2D},
  label = {MTConnect Part 4.0},
  volume = {Part 4.0},
  version = {2.0},
  keywords = {MTC}
  }

@manual{MTCPart5,
  title = {{MTConnect Standard: Part 5.0 - Interface Interaction Model}},
  %url = {http://bit.ly/2pPNGFY},
  label = {MTConnect Part 5.0},
  volume = {Part 5.0},
  version = {2.0},
  keywords = {MTC}
  }
&#10;
&#10;&#10;&#10;External References&#10;&#10;&#10;&#10;@article{Gerkey2004,
    title = {{A formal analysis and taxonomy of task allocation in multi-robot systems}},
    year = {2004},
    journal = {International Journal of Robotics Research},
    author = {Gerkey, Brian P. and Matari{\\'{c}}, Maja J.},
    isbn = {0278-3649},
    doi = {10.1177/0278364904045564},
    issn = {02783649},
    pmid = {13688984},
    keywords = {Coordination, Multi-robot systems, Task allocation, Utility}
}

@book{Gamma1994,
    title = {{Design Patterns: Elements of Reusable Object-Oriented Software}},
    year = {1994},
    author = {Gamma, Erich and Heml, Richard and Johnson, Ralph and Vlissides, John},
    pages = {107},
    publisher = {Addison Wesley},
    isbn = {ISBN 0-201-63361-2}
}

@article{Birman1987,
    title = {{Exploiting virtual synchrony in distributed systems}},
    year = {1987},
    journal = {ACM SIGOPS Operating Systems Review},
    author = {Birman, K. and Joseph, T.},
    isbn = {089791242X},
    doi = {10.1145/37499.37515},
    issn = {01635980},
    pmid = {21463384}
}

@misc{ISO2011,
    title = {{ISO/IEC 42010:2011}},
    year = {2011},
    booktitle = {Systems and software engineering - Architecture description},
    author = {{ISO}},
    number = {March},
    pages = {1--46},
    volume = {2011},
    url = {http://ieeexplore.ieee.org/xpl/articleDetails.jsp?tp=&arnumber=6129467&contentType=Standards&sortType=asc_p_Sequence&filter=AND(p_Publication_Number:6129465)},
    isbn = {978-0-7456-5060-9},
    doi = {10.1081/E-ELIS3-120044716},
    issn = {10655077},
    pmid = {15814772}
}

@article{ISOInternationalOrganizationforStandardization2011,
    title = {{ISO/IEC/IEEE 42010:2011 - Systems and software engineering -- Architecture description}},
    year = {2011},
    journal = {ISOIECIEEE 420102011E Revision of ISOIEC 420102007 and IEEE Std 14712000},
    author = {{ISO (International Organization for Standardization)}},
    number = {March},
    pages = {1--46},
    volume = {2011},
    isbn = {VO -},
    doi = {10.1109/IEEESTD.2011.6129467},
    issn = {0028-0836}
}

@phdthesis{Fielding2000ArchitecturalArchitectures,
    title = {{Architectural Styles and the Design of Network-based Software Architectures}},
    year = {2000},
    booktitle = {Doctoral thesis},
    author = {Fielding, Roy Thomas},
    isbn = {0599871180},
    doi = {10.1.1.91.2433},
    issn = {1098-6596},
    pmid = {25246403},
    arxivId = {arXiv:1011.1669v3}
}&#10;
&#10;&#10;&#10;Main Template TEX&#10;&#10;&#10;&#10;% 					MTCONNECT DOCUMENT TEMPLATE 							%
% 	FILENAME: 		mtconnect.tex											%
%	VERSION:		0.1														%
% 	DATE:			02/13/2018												%
%	PORTED BY:		Moneer Helu												%
%	ADDRESS:		Engineering Laboratory									%
%					National Institute of Standards and Technology (NIST)	%
%					100 Bureau Drive										%
%					Mailstop 8260											%
%					Gaithersburg, MD 20899									%
%					United States of America								%
% 	EMAIL:			moneer.helu@nist.gov									%
% 	DESCRIPTION:	Template for MTConnect documentation;					%
% 					Initial attempt for testing and discussion				%
% 	USAGE:			\\documentclass[options]{mtconnect}						%


\\documentclass{mtconnect}	% Load mtconnect document class

\\input{acronyms.tex}
\\input{glossary.tex}
%\\addbibresource{references.bib}
\\addbibresource{mtc.bib}

%\\hypersetup{draft} %to test without hyperlinks \\hyperref
\\begin{document}			% Begin document here

% REQUIRED INITIAL INPUTS %

\\docnum{}							% Document ""number""
\\doctitle{}	% Full document title
\\doctitleshort{}				% Shortened document title
\\versionnum{}						% MTConnect version
\\preparedfor{MTConnect Institute}		% Should not change!!!
\\preparedfrom{\\href{https://model.mtconnect.org/MTConnectSysMLModel.xml}{\\texttt{MTConnectSysMLModel.xml}}}		% Model link
\\preparedon{\\today}			% Date prepared

% FRONT MATTER (DO NOT CHANGE!!!) %

\\begin{nolinenumbers}
\\maketitle				% Title page

\\pagenumbering{roman}

% MTConnect Specification and Material Statement:
\\textbf{\\color{mtc1}\\Large MTConnect Specification and Materials} \\\\

\\input{legal.tex}

\\clearpage
\\tableofcontents
\\thispagestyle{fancy}
\\clearpage
\\iffigures
   \\listoffigures
\\fi
\\thispagestyle{fancy}
\\clearpage
\\iftables
   \\listoftables
\\fi
\\end{nolinenumbers}

\\pagenumbering{arabic}

% ENTER DOCUMENT CONTENT BELOW %

\\input{introduction.tex}

\\input{%MAIN%}

\\input{profile.tex}

\\input{appendix.tex}

\\end{document}
&#10;
&#10;&#10;&#10;Appendix&#10;&#10;&#10;&#10;{{appendix()}}
{{section*{Appendices}()}}
{{addcontentsline{toc}{section}{Appendices}()}}
{{renewcommand{\\thesubsection}{\\Alph{subsection}}()}}

## Bibliography

Engineering Industries Association. EIA Standard - EIA-274-D, Interchangeable Variable, Block Data Format for Positioning, Contouring, and Contouring/Positioning Numerically Controlled Machines. Washington, D.C. 1979.

ISO TC 184/SC4/WG3 N1089. ISO/DIS 10303-238: Industrial automation systems and integration  Product data representation and exchange  Part 238: Application Protocols: Application interpreted model for computerized numerical controllers. Geneva, Switzerland, 2004.

International Organization for Standardization. ISO 14649: Industrial automation systems and integration – Physical device control – Data model for computerized numerical controllers – Part 10: General process data. Geneva, Switzerland, 2004.

International Organization for Standardization. ISO 14649: Industrial automation systems and integration – Physical device control – Data model for computerized numerical controllers – Part 11: Process data for milling. Geneva, Switzerland, 2000.

International Organization for Standardization. ISO 6983/1 – Numerical Control of machines – Program format and definition of address words – Part 1: Data format for positioning, line and contouring control systems. Geneva, Switzerland, 1982.

Electronic Industries Association. ANSI/EIA-494-B-1992, 32 Bit Binary CL (BCL) and 7 Bit ASCII CL (ACL) Exchange Input Format for Numerically Controlled Machines. Washington, D.C. 1992.

National Aerospace Standard. Uniform Cutting Tests - NAS Series: Metal Cutting Equipment Specifications. Washington, D.C. 1969.

International Organization for Standardization. ISO 10303-11: 1994, Industrial automation systems and integration  Product data representation and exchange  Part 11: Description methods: The EXPRESS language reference manual. Geneva, Switzerland, 1994.

International Organization for Standardization. ISO 10303-21: 1996, Industrial automation systems and integration -- Product data representation and exchange -- Part 21: Implementation methods: Clear text encoding of the exchange structure. Geneva, Switzerland, 1996.

H.L. Horton, F.D. Jones, and E. Oberg. Machinery's Handbook. Industrial Press, Inc. New York, 1984.

International Organization for Standardization. ISO 841-2001: Industrial automation systems and integration - Numerical control of machines - Coordinate systems and motion nomenclature. Geneva, Switzerland, 2001.

ASME B5.57: Methods for Performance Evaluation of Computer Numerically Controlled Lathes and Turning Centers, 1998.

ASME/ANSI B5.54: Methods for Performance Evaluation of Computer Numerically Controlled Machining Centers. 2005.

OPC Foundation. OPC Unified Architecture Specification, Part 1: Concepts Version 1.00. July 28, 2006.

IEEE STD 1451.0-2007, Standard for a Smart Transducer Interface for Sensors and Actuators – Common Functions, Communication Protocols, and Transducer Electronic Data Sheet (TEDS) Formats, IEEE Instrumentation and Measurement Society, TC-9, The Institute of Electrical and Electronics Engineers, Inc., New York, N.Y. 10016, SH99684, October 5, 2007.

IEEE STD 1451.4-1994, Standard for a Smart Transducer Interface for Sensors and Actuators – Mixed-Mode Communication Protocols and Transducer Electronic Data Sheet (TEDS) Formats, IEEE Instrumentation and Measurement Society, TC-9, The Institute of Electrical and Electronics Engineers, Inc., New York, N.Y. 10016, SH95225, December 15, 2004. &#10;
&#10;&#10;&#10;Main Template MD&#10;&#10;&#10;&#10;# MTConnect Specification and Material Statement

{{input(legal.md)}}

{{input(introduction.md)}}

{{input(%MAIN%)}}

{{input(profile.md)}}

{{input(appendix.md)}}&#10;
";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
		};
		#region Packages
	#endregion

	#region Classes
	#endregion
	}
}