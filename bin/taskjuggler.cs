#!/bin/env python
# -*- coding: utf-8 -*-

""" #+begin_org
* ~[Summary]~ :: A =CSXU= (Direct, Atomic) for managing taskjuggler.
#+end_org """

""" #+begin_org
* [[elisp:(org-cycle)][| ~Description~ |]] :: [[file:/bisos/git/auth/bxRepos/blee-binders/blee-core/org-mode/ox-taskjuggler/_nodeBase_/fullUsagePanel-en.org][BISOS Panel]]   [[elisp:(org-cycle)][| ]]
 This Atomic-Direct-XU manages taskjuggler files (timeLine.tjp) that are derived from (timeLine.org)
 See /bisos/panels/blee-core/org-mode/ox-taskjuggler/_nodeBase_  directory as an example (accountingExample.org).
 The commands in this XU mimic those of /var/bisos/blee/emacsVers/28.2/doom-run-blee3/.local/straight/build-28.2/ox-taskjuggler/ox-taskjuggler.el
 and in particular (org-taskjuggler-export-and-process) and  (org-taskjuggler-export-process-and-open). 

 We are expecting that the export has been made and the .tjp file is in place.

The tj3Process (csCmnd) creates the reports directory in the base directory of the .tjp file. 
      tj3Process receives one argument: the path to the .tjp file.

The tj3OpenHtmls(csCmnd) Opens the reports/Plan.html, Gantt.html, and Resources.html files in the browser 
      tj3OpenHtmls receives one argument: the path to the .tjp file.

The tj3ProcessAndOpen (csCmnd) does both of the above: it creates the reports and then opens the Plan.html in the browser. 
      tj3ProcessAndOpen receives one argument: the path to the .tjp file.

The tj3HtmlsToImages (csCmnd) converts the Plan.html, Gantt.html, and Resources.html files into image formats.
     receives one argument: the path to the .tjp file.
     It uses playwright to capture screenshots of all three HTML reports.

The tj3FullProc (csCmnd) does the full processing: it runs tj3Process and tj3HtmlsToImages
     receives one argument: the path to the .tjp file.
     
** Status: In use with BISOS
** /[[elisp:(org-cycle)][| Planned Improvements |]]/ :
*** TODO Review Panel's Design and Evolution section.
#+end_org """


####+BEGIN: b:py3:cs:file/dblockControls :classification "cs-mu"
""" #+begin_org
* [[elisp:(org-cycle)][| /Control Parameters Of This File/ |]] :: dblk ctrls classifications=cs-mu
#+BEGIN_SRC emacs-lisp
(setq-local b:dblockControls t) ; (setq-local b:dblockControls nil)
(put 'b:dblockControls 'py3:cs:Classification "cs-mu") ; one of cs-mu, cs-u, cs-lib, bpf-lib, pyLibPure
#+END_SRC
#+RESULTS:
: cs-mu
#+end_org """
####+END:

####+BEGIN: b:prog:file/proclamations :outLevel 1
""" #+begin_org
* *[[elisp:(org-cycle)][| Proclamations |]]* :: Libre-Halaal Software --- Part Of BISOS ---  Poly-COMEEGA Format.
** This is Libre-Halaal Software. © Neda Communications, Inc. Subject to AGPL.
** It is part of BISOS (ByStar Internet Services OS)
** Best read and edited  with Blee in Poly-COMEEGA (Polymode Colaborative Org-Mode Enhance Emacs Generalized Authorship)
#+end_org """
####+END:

####+BEGIN: b:prog:file/particulars :authors ("./inserts/authors-mb.org")
""" #+begin_org
* *[[elisp:(org-cycle)][| Particulars |]]* :: Authors, version
** This File: /bisos/git/bxRepos/bisos-pip/csPlayer/py3/bin/player.cs
** File True Name: /bisos/git/auth/bxRepos/bisos-pip/csPlayer/py3/bin/player.cs
** Authors: Mohsen BANAN, http://mohsen.banan.1.byname.net/contact
#+end_org """
####+END:

####+BEGIN: b:py3:file/particulars-csInfo :status "inUse"
""" #+begin_org
* *[[elisp:(org-cycle)][| Particulars-csInfo |]]*
#+end_org """
import typing
csInfo: typing.Dict[str, typing.Any] = { 'moduleName': ['player'], }
csInfo['version'] = '202601111431'
csInfo['status']  = 'inUse'
csInfo['panel'] = 'player-Panel.org'
csInfo['groupingType'] = 'IcmGroupingType-pkged'
csInfo['cmndParts'] = 'IcmCmndParts[common] IcmCmndParts[param]'
####+END:


####+BEGIN: b:prog:file/orgTopControls :outLevel 1
""" #+begin_org
* [[elisp:(org-cycle)][| Controls |]] :: [[elisp:(delete-other-windows)][(1)]] | [[elisp:(show-all)][Show-All]]  [[elisp:(org-shifttab)][Overview]]  [[elisp:(progn (org-shifttab) (org-content))][Content]] | [[file:Panel.org][Panel]] | [[elisp:(blee:ppmm:org-mode-toggle)][Nat]] | [[elisp:(bx:org:run-me)][Run]] | [[elisp:(bx:org:run-me-eml)][RunEml]] | [[elisp:(progn (save-buffer) (kill-buffer))][S&Q]]  [[elisp:(save-buffer)][Save]]  [[elisp:(kill-buffer)][Quit]] [[elisp:(org-cycle)][| ]]
** /Version Control/ ::  [[elisp:(call-interactively (quote cvs-update))][cvs-update]]  [[elisp:(vc-update)][vc-update]] | [[elisp:(bx:org:agenda:this-file-otherWin)][Agenda-List]]  [[elisp:(bx:org:todo:this-file-otherWin)][ToDo-List]]

#+end_org """
####+END:

####+BEGIN: b:py3:file/workbench :outLevel 1
""" #+begin_org
* [[elisp:(org-cycle)][| Workbench |]] :: [[elisp:(python-check (format "/bisos/venv/py3/bisos3/bin/python -m pyclbr %s" (bx:buf-fname))))][pyclbr]] || [[elisp:(python-check (format "/bisos/venv/py3/bisos3/bin/python -m pydoc ./%s" (bx:buf-fname))))][pydoc]] || [[elisp:(python-check (format "/bisos/pipx/bin/pyflakes %s" (bx:buf-fname)))][pyflakes]] | [[elisp:(python-check (format "/bisos/pipx/bin/pychecker %s" (bx:buf-fname))))][pychecker (executes)]] | [[elisp:(python-check (format "/bisos/pipx/bin/pycodestyle %s" (bx:buf-fname))))][pycodestyle]] | [[elisp:(python-check (format "/bisos/pipx/bin/flake8 %s" (bx:buf-fname))))][flake8]] | [[elisp:(python-check (format "/bisos/pipx/bin/pylint %s" (bx:buf-fname))))][pylint]]  [[elisp:(org-cycle)][| ]]
#+end_org """
####+END:

####+BEGIN: b:py3:cs:framework/imports :basedOn "classification"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  CsFrmWrk   [[elisp:(outline-show-subtree+toggle)][||]] *Imports* =Based on Classification=cs-mu=
#+end_org """
from bisos import b
from bisos.b import cs
from bisos.b import b_io

import collections
####+END:

import pathlib

import typing
import sys
import os

####+BEGIN: b:py3:cs:framework/csxuSeeded :disabled? t :comment "Import plantedCsu"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  /DISABLED/   [[elisp:(outline-show-subtree+toggle)][||]] *b:py3:cs:framework/csxuSeeded*  [[elisp:(org-cycle)][| ]]
#+end_org """
####+END:

""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  CsFrmWrk   [[elisp:(outline-show-subtree+toggle)][||]] ~csuList emacs-list Specifications~  [[elisp:(blee:org:code-block/above-run)][ /Eval Below/ ]] [[elisp:(org-cycle)][| ]]
#+BEGIN_SRC emacs-lisp
(setq  b:py:cs:csuList
  (list
 ))
#+END_SRC
#+RESULTS:
#+end_org """

####+BEGIN: b:py3:cs:framework/csuListProc :pyImports t :csuImports t :csuParams t :csxuParams nil
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  CsFrmWrk   [[elisp:(outline-show-subtree+toggle)][||]] ~Process CSU List~ with /0/ in csuList pyImports=t csuImports=t csuParams=t
#+end_org """


csuList = [ ]

g_importedCmndsModules = cs.csuList_importedModules(csuList)

def g_extraParams():
    csParams = cs.param.CmndParamDict()
    cs.csuList_commonParamsSpecify(csuList, csParams)
    cs.argsparseBasedOnCsParams(csParams)

####+END:

####+BEGIN: b:py3:cs:main/exposedSymbols :disabled? t :classes ()
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  /DISABLED/   [[elisp:(outline-show-subtree+toggle)][||]] *b:py3:cs:main/exposedSymbols*  [[elisp:(org-cycle)][| ]]
#+end_org """
####+END:

####+BEGIN: b:py3:cs:main/outcomeReportControl :disabled? nil :cmnd t :ro nil
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  CsFrmWrk   [[elisp:(outline-show-subtree+toggle)][||]] ~Invokation's Outcome Reporting Control~ with /cmnd=t/ /ro=nil/
#+end_org """
# cs.invOutcomeReportControl(cmnd=True, ro=True)
####+END:


####+BEGIN: b:py3:cs:framework/uploadLoader :disabled? nil :comment "upload with loader_facter"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  CsFrmWrk   [[elisp:(outline-show-subtree+toggle)][||]] ~Upload Loader~ Setup Loader
#+end_org """
####+END:


####+BEGIN: blee:bxPanel:foldingSection :outLevel 0 :sep nil :title "CmndSvcs" :anchor ""  :extraInfo "Command Services Section"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*     [[elisp:(outline-show-subtree+toggle)][| _CmndSvcs_: |]]  Command Services Section  [[elisp:(org-shifttab)][<)]] E|
#+end_org """
####+END:

####+BEGIN: b:py3:cs:cmnd/classHead :cmndName "examples" :extent "verify" :ro "noCli" :comment "FrameWrk: CS-Main-Examples" :parsMand "" :parsOpt "" :argsMin 0 :argsMax 0 :pyInv ""
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  CmndSvc-   [[elisp:(outline-show-subtree+toggle)][||]] <<examples>>  *FrameWrk: CS-Main-Examples*  =verify= ro=noCli   [[elisp:(org-cycle)][| ]]
#+end_org """
class examples(cs.Cmnd):
    cmndParamsMandatory = [ ]
    cmndParamsOptional = [ ]
    cmndArgsLen = {'Min': 0, 'Max': 0,}
    rtInvConstraints = cs.rtInvoker.RtInvoker.new_noRo() # NO RO From CLI

    @cs.track(fnLoc=True, fnEntry=True, fnExit=True)
    def cmnd(self,
             rtInv: cs.RtInvoker,
             cmndOutcome: b.op.Outcome,
    ) -> b.op.Outcome:
        """FrameWrk: CS-Main-Examples"""
        failed = b_io.eh.badOutcome
        callParamsDict = {}
        if self.invocationValidate(rtInv, cmndOutcome, callParamsDict, None).isProblematic():
            return failed(cmndOutcome)
####+END:
        self.cmndDocStr(f""" #+begin_org
***** [[elisp:(org-cycle)][| *CmndDesc:* | ]]  Conventional top level example.
        #+end_org """)

        cs.G.icmRunArgsGet().perfName = None   # NOTYET

        od = collections.OrderedDict
        cmnd = cs.examples.cmndEnter
        literal = cs.examples.execInsert

        #logControler = b_io.log.Control()
        #logControler.loggerSetLevel(20)

        cs.examples.myName(cs.G.icmMyName(), cs.G.icmMyFullName())
        cs.examples.commonBrief()

        cs.examples.menuChapter('=TaskJuggler Processing=  *Process .tjp Files*')

        cmnd('tj3Process', args='/bisos/git/auth/bxRepos/blee-binders/blee-core/org-mode/ox-taskjuggler/_nodeBase_/accountingExample.tjp', comment="# Process a TaskJuggler file")
        cmnd('tj3Process', args='timeLine.tjp', comment="# Process with relative path")

        cs.examples.menuChapter('=Opening TaskJuggler Reports=  *Open Plan.html, Gantt.html, and Resources.html in Browser*')

        cmnd('tj3OpenHtmls', args='/bisos/git/auth/bxRepos/blee-binders/blee-core/org-mode/ox-taskjuggler/_nodeBase_/accountingExample.tjp', comment="# Open all HTML reports from processed .tjp file")
        cmnd('tj3OpenHtmls', args='timeLine.tjp', comment="# Open all HTML reports with relative path")

        cs.examples.menuChapter('=Processing and Opening=  *Process .tjp and Open Plan in Browser*')

        cmnd('tj3ProcessAndOpen', args='/bisos/git/auth/bxRepos/blee-binders/blee-core/org-mode/ox-taskjuggler/_nodeBase_/accountingExample.tjp', comment="# Process and open Plan.html")
        cmnd('tj3ProcessAndOpen', args='timeLine.tjp', comment="# Process and open with relative path")

        cs.examples.menuChapter('=Converting to Image=  *Convert Plan.html to PNG Screenshot*')

        cmnd('tj3HtmlsToImages', args='/bisos/git/auth/bxRepos/blee-binders/blee-core/org-mode/ox-taskjuggler/_nodeBase_/accountingExample.tjp', comment="# Convert Plan/Gantt/Resources HTML to PNG images")
        cmnd('tj3HtmlsToImages', args='timeLine.tjp', comment="# Convert all HTML reports to PNG with relative path")

        cs.examples.menuChapter('=Full Processing=  *Process .tjp and Generate Both Reports and Image*')

        cmnd('tj3FullProc', args='/bisos/git/auth/bxRepos/blee-binders/blee-core/org-mode/ox-taskjuggler/_nodeBase_/accountingExample.tjp', comment="# Full processing: process and convert to image")
        cmnd('tj3FullProc', args='timeLine.tjp', comment="# Full processing with relative path")

        cs.examples.menuChapter('=ExecLine Example=  *Example Of Command Line*')

        literal(f"""tj3 --silent --no-color --output-dir reports accountingExample.tjp""")

        return(cmndOutcome)

####+BEGIN: b:py3:cs:cmnd/classHead :cmndName "tj3Process" :comment "" :extent "verify" :ro "cli" :parsMand "" :parsOpt "" :argsMin 1 :argsMax 1 :pyInv ""
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  CmndSvc-   [[elisp:(outline-show-subtree+toggle)][||]] <<tj3Process>>  =verify= argsMax=1 ro=cli   [[elisp:(org-cycle)][| ]]
#+end_org """
class tj3Process(cs.Cmnd):
    cmndParamsMandatory = [ ]
    cmndParamsOptional = [ ]
    cmndArgsLen = {'Min': 1, 'Max': 1,}

    @cs.track(fnLoc=True, fnEntry=True, fnExit=True)
    def cmnd(self,
             rtInv: cs.RtInvoker,
             cmndOutcome: b.op.Outcome,
             argsList: typing.Optional[list[str]]=None,  # CsArgs
    ) -> b.op.Outcome:

        failed = b_io.eh.badOutcome
        callParamsDict = {}
        if self.invocationValidate(rtInv, cmndOutcome, callParamsDict, argsList).isProblematic():
            return failed(cmndOutcome)
        cmndArgsSpecDict = self.cmndArgsSpec()
####+END:
        self.cmndDocStr(f""" #+begin_org
** [[elisp:(org-cycle)][| *CmndDesc:* | ]]  Process a TaskJuggler file and generate three HTML reports.
 Based on org-taskjuggler-compile from ox-taskjuggler.el
 Creates a reports directory and processes the .tjp file using tj3 three times.
 Each invocation generates a separate HTML report:
   - Plan.html (combined Gantt and Resources)
   - Gantt.html (Gantt chart only)
   - Resources.html (Resources allocation only)
 Uses the --report flag to select which report to generate.
        #+end_org """)

        cmndArg = self.cmndArgsGet("0", cmndArgsSpecDict, argsList)
        tjpFilePath = cmndArg

        # Debug logging
        b_io.log.info(f"Raw argument received: {tjpFilePath}")
        b_io.log.info(f"Argument type: {type(tjpFilePath)}")

        # Convert to absolute path
        tjpFilePathAbs = pathlib.Path(tjpFilePath).resolve()

        b_io.log.info(f"Resolved path: {tjpFilePathAbs}")
        b_io.log.info(f"Path exists: {tjpFilePathAbs.exists()}")
        b_io.log.info(f"Path is file: {tjpFilePathAbs.is_file()}")
        b_io.log.info(f"Path is dir: {tjpFilePathAbs.is_dir()}")

        # Validate that the file exists
        if not tjpFilePathAbs.exists():
            b_io.eh.problem(f"TaskJuggler file not found: {tjpFilePathAbs}")
            return failed(cmndOutcome)

        if not tjpFilePathAbs.is_file():
            b_io.eh.problem_usageError(f"Path is not a file: {tjpFilePathAbs}")
            # Additional debugging
            if tjpFilePathAbs.is_dir():
                b_io.eh.critical(f"Path is a directory, not a file")
            return failed(cmndOutcome)

        # Get the directory containing the .tjp file
        tjpDir = tjpFilePathAbs.parent

        # Default reports directory is "reports" relative to tjp file
        reportsDir = tjpDir / "reports"

        # Create reports directory if it doesn't exist
        try:
            reportsDir.mkdir(parents=True, exist_ok=True)
        except Exception as e:
            b_io.eh.critical(f"Failed to create reports directory {reportsDir}: {e}")
            return failed(cmndOutcome)

        # Run tj3 three times to generate three different reports
        # Each run generates a separate HTML file: Plan.html, Gantt.html, Resources.html
        reports = [
            ("Plan", "Plan.html (combined Gantt and Resources)"),
            ("Gantt", "Gantt.html (Gantt chart only)"),
            ("Resources", "Resources.html (Resources allocation only)")
        ]
        
        failedReports = []
        generatedFiles = []

        b_io.log.info(f"Processing TaskJuggler files: {tjpFilePathAbs}")
        b_io.log.info(f"Reports directory: {reportsDir}")
        b_io.log.info(f"Generating {len(reports)} reports...")

        for reportName, reportDesc in reports:
            # Determine the .tjp file for this specific report
            # Pattern: file.tjp -> file-gantt.tjp, file-resources.tjp, file.tjp (for Plan)
            if reportName == "Plan":
                tjpForReport = tjpFilePathAbs
            elif reportName == "Gantt":
                tjpForReport = tjpFilePathAbs.parent / f"{tjpFilePathAbs.stem}-gantt.tjp"
            elif reportName == "Resources":
                tjpForReport = tjpFilePathAbs.parent / f"{tjpFilePathAbs.stem}-resources.tjp"
            else:
                tjpForReport = tjpFilePathAbs
            
            # Verify the .tjp file exists
            if not tjpForReport.exists():
                b_io.log.warning(f"Skipping {reportName}: file not found: {tjpForReport}")
                failedReports.append(reportName)
                continue

            # Build the tj3 command
            # Command format: tj3 --silent --no-color --output-dir <reports-dir> <tjp-file>
            tj3Command = f"tj3 --silent --no-color --output-dir {reportsDir} {tjpForReport}"

            b_io.log.info(f"  Generating {reportDesc}")
            b_io.log.info(f"  Command: {tj3Command}")

            subProcResult = b.subProc.WOpW(invedBy=self, log=1).bash(tj3Command)

            if subProcResult.isProblematic():
                b_io.eh.error(f"TaskJuggler processing failed for report: {reportName}")
                failedReports.append(reportName)
            else:
                # Collect errors from output (if any)
                errors = self._collectErrors(subProcResult.stdout)
                if errors:
                    b_io.eh.warning(f"TaskJuggler warnings for {reportName}: {errors}")
                    failedReports.append(reportName)

        if failedReports:
            b_io.eh.error(f"Failed to generate reports: {', '.join(failedReports)}")
            return failed(cmndOutcome)

        # Find and list all generated HTML files
        htmlFiles = list(reportsDir.glob("*.html"))

        if not htmlFiles:
            b_io.eh.warning(f"No HTML reports generated in {reportsDir}")
            return cmndOutcome.set(
                opResults=f"Processing completed but no HTML files generated",
            )

        # Return list of generated HTML files
        htmlFilesList = [str(f) for f in htmlFiles]
        b_io.log.info(f"Generated {len(htmlFilesList)} HTML report(s)")

        return cmndOutcome.set(
            opResults=htmlFilesList,
        )

    def _collectErrors(self, output: str) -> typing.Optional[str]:
        """Collect error messages from tj3 command output.
        
        Parses output for error patterns like: file.tjp:10: Error message
        Returns collected error string or None if no errors.
        """
        import re
        if not output:
            return None

        errors = []
        # Pattern: filename:linenumber: error message
        pattern = r'^.+:\d+: (.*)$'
        for line in output.split('\n'):
            match = re.match(pattern, line)
            if match:
                errors.append(match.group(1))

        return " ".join(errors) if errors else None

####+BEGIN: b:py3:cs:method/args :methodName "cmndArgsSpec" :methodType "anyOrNone" :retType "bool" :deco "default" :argsList "self"
    """ #+begin_org
**  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  Mtd-T-anyOrNone [[elisp:(outline-show-subtree+toggle)][||]] /cmndArgsSpec/ deco=default  deco=default  [[elisp:(org-cycle)][| ]]
    #+end_org """
    @cs.track(fnLoc=True, fnEntry=True, fnExit=True)
    def cmndArgsSpec(self, ):
####+END:
        """  #+begin_org
*** [[elisp:(org-cycle)][| *cmndArgsSpec:* | ]] Path to TaskJuggler file
        #+end_org """

        cmndArgsSpecDict = cs.arg.CmndArgsSpecDict()
        cmndArgsSpecDict.argsDictAdd(
            argPosition="0",
            argName="tjpFilePath",
            argChoices=[],
            argDescription="Path to the TaskJuggler .tjp file to process"
        )

        return cmndArgsSpecDict


####+BEGIN: b:py3:cs:cmnd/classHead :cmndName "tj3OpenHtmls" :comment "" :extent "verify" :ro "cli" :parsMand "" :parsOpt "" :argsMin 1 :argsMax 1 :pyInv ""
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  CmndSvc-   [[elisp:(outline-show-subtree+toggle)][||]] <<tj3OpenHtmls>>  =verify= argsMax=1 ro=cli   [[elisp:(org-cycle)][| ]]
#+end_org """
class tj3OpenHtmls(cs.Cmnd):
    cmndParamsMandatory = [ ]
    cmndParamsOptional = [ ]
    cmndArgsLen = {'Min': 1, 'Max': 1,}

    @cs.track(fnLoc=True, fnEntry=True, fnExit=True)
    def cmnd(self,
             rtInv: cs.RtInvoker,
             cmndOutcome: b.op.Outcome,
             argsList: typing.Optional[list[str]]=None,  # CsArgs
    ) -> b.op.Outcome:

        failed = b_io.eh.badOutcome
        callParamsDict = {}
        if self.invocationValidate(rtInv, cmndOutcome, callParamsDict, argsList).isProblematic():
            return failed(cmndOutcome)
        cmndArgsSpecDict = self.cmndArgsSpec()
####+END:
        self.cmndDocStr(f""" #+begin_org
** [[elisp:(org-cycle)][| *CmndDesc:* | ]]  Open the Plan.html, Gantt.html, and Resources.html reports in the default browser.
 Opens reports/Plan.html, reports/Gantt.html, and reports/Resources.html that were generated by tj3Process.
        #+end_org """)

        cmndArg = self.cmndArgsGet("0", cmndArgsSpecDict, argsList)
        tjpFilePath = cmndArg

        # Convert to absolute path
        tjpFilePathAbs = pathlib.Path(tjpFilePath).resolve()

        b_io.log.info(f"Opening Plan from: {tjpFilePathAbs}")

        # Validate that the file exists
        if not tjpFilePathAbs.exists():
            b_io.eh.problem(f"TaskJuggler file not found: {tjpFilePathAbs}")
            return failed(cmndOutcome)

        if not tjpFilePathAbs.is_file():
            b_io.eh.problem_usageError(f"Path is not a file: {tjpFilePathAbs}")
            return failed(cmndOutcome)

        # Get the directory containing the .tjp file
        tjpDir = tjpFilePathAbs.parent

        # List of HTML files to open: (display name, filename)
        htmlFiles = [
            ("Plan", "Plan.html"),
            ("Gantt", "Gantt.html"),
            ("Resources", "Resources.html"),
        ]

        openedCount = 0
        openedFiles = []

        try:
            import webbrowser

            for reportName, htmlFileName in htmlFiles:
                htmlPath = tjpDir / "reports" / htmlFileName

                b_io.log.info(f"Looking for {reportName}.html at: {htmlPath}")

                # Skip missing files gracefully
                if not htmlPath.exists():
                    b_io.eh.warn(f"{reportName}.html not found at: {htmlPath}")
                    continue

                if not htmlPath.is_file():
                    b_io.eh.warn(f"Path is not a file: {htmlPath}")
                    continue

                # Open the HTML file in the default browser
                htmlUrl = htmlPath.as_uri()  # Convert to file:// URL
                b_io.log.info(f"Opening: {reportName} - {htmlUrl}")
                webbrowser.open(htmlUrl)
                openedCount += 1
                openedFiles.append(reportName)

        except Exception as e:
            b_io.eh.problem(f"Failed to open HTML reports: {e}")
            return failed(cmndOutcome)

        if openedCount == 0:
            b_io.eh.problem(f"No HTML reports found in: {tjpDir / 'reports'}")
            b_io.eh.info(f"Did you run tj3Process first?")
            return failed(cmndOutcome)

        return cmndOutcome.set(
            opResults=f"Opened {openedCount} report(s): {', '.join(openedFiles)} from {tjpDir}",
        )

####+BEGIN: b:py3:cs:method/args :methodName "cmndArgsSpec" :methodType "anyOrNone" :retType "bool" :deco "default" :argsList "self"
    """ #+begin_org
**  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  Mtd-T-anyOrNone [[elisp:(outline-show-subtree+toggle)][||]] /cmndArgsSpec/ deco=default  deco=default  [[elisp:(org-cycle)][| ]]
    #+end_org """
    @cs.track(fnLoc=True, fnEntry=True, fnExit=True)
    def cmndArgsSpec(self, ):
####+END:
        """  #+begin_org
*** [[elisp:(org-cycle)][| *cmndArgsSpec:* | ]] Path to TaskJuggler file
        #+end_org """

        cmndArgsSpecDict = cs.arg.CmndArgsSpecDict()
        cmndArgsSpecDict.argsDictAdd(
            argPosition="0",
            argName="tjpFilePath",
            argChoices=[],
            argDescription="Path to the TaskJuggler .tjp file (to find the reports directory)"
        )

        return cmndArgsSpecDict


####+BEGIN: b:py3:cs:cmnd/classHead :cmndName "tj3ProcessAndOpen" :comment "" :extent "verify" :ro "cli" :parsMand "" :parsOpt "" :argsMin 1 :argsMax 1 :pyInv ""
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  CmndSvc-   [[elisp:(outline-show-subtree+toggle)][||]] <<tj3ProcessAndOpen>>  =verify= argsMax=1 ro=cli   [[elisp:(org-cycle)][| ]]
#+end_org """
class tj3ProcessAndOpen(cs.Cmnd):
    cmndParamsMandatory = [ ]
    cmndParamsOptional = [ ]
    cmndArgsLen = {'Min': 1, 'Max': 1,}

    @cs.track(fnLoc=True, fnEntry=True, fnExit=True)
    def cmnd(self,
             rtInv: cs.RtInvoker,
             cmndOutcome: b.op.Outcome,
             argsList: typing.Optional[list[str]]=None,  # CsArgs
    ) -> b.op.Outcome:

        failed = b_io.eh.badOutcome
        callParamsDict = {}
        if self.invocationValidate(rtInv, cmndOutcome, callParamsDict, argsList).isProblematic():
            return failed(cmndOutcome)
        cmndArgsSpecDict = self.cmndArgsSpec()
####+END:
        self.cmndDocStr(f""" #+begin_org
** [[elisp:(org-cycle)][| *CmndDesc:* | ]]  Process a TaskJuggler file and open all HTML reports in browser.
 Combines tj3Process and tj3OpenHtmls: processes the .tjp file and then opens all the reports.
        #+end_org """)

        cmndArg = self.cmndArgsGet("0", cmndArgsSpecDict, argsList)
        tjpFilePath = cmndArg

        # Step 1: Run tj3Process
        b_io.log.info(f"Processing and opening: {tjpFilePath}")
        
        processCmd = tj3Process(invocation=None)
        processOutcome = b.op.Outcome()
        processResult = processCmd.cmnd(
            rtInv=rtInv,
            cmndOutcome=processOutcome,
            argsList=[tjpFilePath]
        )

        if processResult.isProblematic():
            b_io.eh.error(f"Failed to process TaskJuggler file")
            return failed(cmndOutcome)

        # Step 2: Run tj3OpenHtmls
        openCmd = tj3OpenHtmls(invocation=None)
        openOutcome = b.op.Outcome()
        openResult = openCmd.cmnd(
            rtInv=rtInv,
            cmndOutcome=openOutcome,
            argsList=[tjpFilePath]
        )

        if openResult.isProblematic():
            b_io.eh.error(f"Failed to open HTML reports")
            return failed(cmndOutcome)

        return cmndOutcome.set(
            opResults=f"Processed and opened reports from: {tjpFilePath}",
        )

####+BEGIN: b:py3:cs:method/args :methodName "cmndArgsSpec" :methodType "anyOrNone" :retType "bool" :deco "default" :argsList "self"
    """ #+begin_org
**  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  Mtd-T-anyOrNone [[elisp:(outline-show-subtree+toggle)][||]] /cmndArgsSpec/ deco=default  deco=default  [[elisp:(org-cycle)][| ]]
    #+end_org """
    @cs.track(fnLoc=True, fnEntry=True, fnExit=True)
    def cmndArgsSpec(self, ):
####+END:
        """  #+begin_org
*** [[elisp:(org-cycle)][| *cmndArgsSpec:* | ]] Path to TaskJuggler file
        #+end_org """

        cmndArgsSpecDict = cs.arg.CmndArgsSpecDict()
        cmndArgsSpecDict.argsDictAdd(
            argPosition="0",
            argName="tjpFilePath",
            argChoices=[],
            argDescription="Path to the TaskJuggler .tjp file to process and open"
        )

        return cmndArgsSpecDict


####+BEGIN: b:py3:cs:cmnd/classHead :cmndName "tj3HtmlsToImages" :comment "" :extent "verify" :ro "cli" :parsMand "" :parsOpt "" :argsMin 1 :argsMax 1 :pyInv ""
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  CmndSvc-   [[elisp:(outline-show-subtree+toggle)][||]] <<tj3HtmlsToImages>>  =verify= argsMax=1 ro=cli   [[elisp:(org-cycle)][| ]]
#+end_org """
class tj3HtmlsToImages(cs.Cmnd):
    cmndParamsMandatory = [ ]
    cmndParamsOptional = [ ]
    cmndArgsLen = {'Min': 1, 'Max': 1,}

    @cs.track(fnLoc=True, fnEntry=True, fnExit=True)
    def cmnd(self,
             rtInv: cs.RtInvoker,
             cmndOutcome: b.op.Outcome,
             argsList: typing.Optional[list[str]]=None,  # CsArgs
    ) -> b.op.Outcome:

        failed = b_io.eh.badOutcome
        callParamsDict = {}
        if self.invocationValidate(rtInv, cmndOutcome, callParamsDict, argsList).isProblematic():
            return failed(cmndOutcome)
        cmndArgsSpecDict = self.cmndArgsSpec()
####+END:
        self.cmndDocStr(f""" #+begin_org
** [[elisp:(org-cycle)][| *CmndDesc:* | ]]  Convert HTML reports to image format (Plan, Gantt, Resources).
 Uses Playwright to capture screenshots of all three HTML files.
 Saves screenshots to reports/Plan.png, reports/Gantt.png, reports/Resources.png.
        #+end_org """)

        cmndArg = self.cmndArgsGet("0", cmndArgsSpecDict, argsList)
        tjpFilePath = cmndArg

        # Convert to absolute path
        tjpFilePathAbs = pathlib.Path(tjpFilePath).resolve()

        b_io.log.info(f"Converting HTML files to images from: {tjpFilePathAbs}")

        # Validate that the file exists
        if not tjpFilePathAbs.exists():
            b_io.eh.problem(f"TaskJuggler file not found: {tjpFilePathAbs}")
            return failed(cmndOutcome)

        if not tjpFilePathAbs.is_file():
            b_io.eh.problem_usageError(f"Path is not a file: {tjpFilePathAbs}")
            return failed(cmndOutcome)

        # Get the directory containing the .tjp file
        tjpDir = tjpFilePathAbs.parent
        reportsDir = tjpDir / "reports"

        # Define the three HTML files to convert
        htmlFiles = [
            ("Plan", "Plan.html"),
            ("Gantt", "Gantt.html"),
            ("Resources", "Resources.html"),
        ]

        b_io.log.info(f"Looking for HTML files in: {reportsDir}")

        # Use Playwright to capture screenshots
        try:
            from playwright.sync_api import sync_playwright
            
            # Launch browser once for all screenshots
            with sync_playwright() as p:
                browser = p.chromium.launch()
                
                successCount = 0
                for reportName, htmlFileName in htmlFiles:
                    htmlPath = reportsDir / htmlFileName
                    imagePath = reportsDir / f"{reportName}.png"
                    
                    if not htmlPath.exists():
                        b_io.log.warn(f"{reportName}.html not found at: {htmlPath}")
                        b_io.log.info(f"Skipping (did you run tj3Process first?)")
                        continue
                    
                    if not htmlPath.is_file():
                        b_io.log.warn(f"Path is not a file: {htmlPath}")
                        continue
                    
                    try:
                        b_io.log.info(f"Capturing {reportName}.html to {reportName}.png")
                        page = browser.new_page()
                        
                        # Load the HTML file using file:// URL
                        htmlUrl = htmlPath.as_uri()
                        b_io.log.info(f"Loading: {htmlUrl}")
                        
                        page.goto(htmlUrl, wait_until="networkidle")
                        
                        # Capture full page screenshot
                        page.screenshot(path=str(imagePath), full_page=True)
                        page.close()
                        
                        b_io.log.info(f"Screenshot saved to: {imagePath}")
                        successCount += 1
                        
                    except Exception as e:
                        b_io.log.warn(f"Failed to capture {reportName}.html: {e}")
                        continue
                
                browser.close()
                
            if successCount == 0:
                b_io.eh.problem(f"No HTML files were converted to images")
                return failed(cmndOutcome)
            
            b_io.log.info(f"Successfully captured {successCount} screenshot(s)")
            
        except ImportError:
            b_io.eh.problem(f"Playwright is not installed. Install with: pip install playwright")
            b_io.eh.info(f"You may also need to run: playwright install")
            return failed(cmndOutcome)
        except Exception as e:
            b_io.eh.problem(f"Failed to capture screenshots: {e}")
            return failed(cmndOutcome)

        return cmndOutcome.set(
            opResults=f"Converted {successCount} HTML file(s) to image(s)",
        )

####+BEGIN: b:py3:cs:method/args :methodName "cmndArgsSpec" :methodType "anyOrNone" :retType "bool" :deco "default" :argsList "self"
    """ #+begin_org
**  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  Mtd-T-anyOrNone [[elisp:(outline-show-subtree+toggle)][||]] /cmndArgsSpec/ deco=default  deco=default  [[elisp:(org-cycle)][| ]]
    #+end_org """
    @cs.track(fnLoc=True, fnEntry=True, fnExit=True)
    def cmndArgsSpec(self, ):
####+END:
        """  #+begin_org
*** [[elisp:(org-cycle)][| *cmndArgsSpec:* | ]] Path to TaskJuggler file
        #+end_org """

        cmndArgsSpecDict = cs.arg.CmndArgsSpecDict()
        cmndArgsSpecDict.argsDictAdd(
            argPosition="0",
            argName="tjpFilePath",
            argChoices=[],
            argDescription="Path to the TaskJuggler .tjp file (to find Plan.html, Gantt.html, Resources.html and save screenshots)"
        )

        return cmndArgsSpecDict


####+BEGIN: b:py3:cs:cmnd/classHead :cmndName "tj3FullProc" :comment "" :extent "verify" :ro "cli" :parsMand "" :parsOpt "" :argsMin 1 :argsMax 1 :pyInv ""
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  CmndSvc-   [[elisp:(outline-show-subtree+toggle)][||]] <<tj3FullProc>>  =verify= argsMax=1 ro=cli   [[elisp:(org-cycle)][| ]]
#+end_org """
class tj3FullProc(cs.Cmnd):
    cmndParamsMandatory = [ ]
    cmndParamsOptional = [ ]
    cmndArgsLen = {'Min': 1, 'Max': 1,}

    @cs.track(fnLoc=True, fnEntry=True, fnExit=True)
    def cmnd(self,
             rtInv: cs.RtInvoker,
             cmndOutcome: b.op.Outcome,
             argsList: typing.Optional[list[str]]=None,  # CsArgs
    ) -> b.op.Outcome:

        failed = b_io.eh.badOutcome
        callParamsDict = {}
        if self.invocationValidate(rtInv, cmndOutcome, callParamsDict, argsList).isProblematic():
            return failed(cmndOutcome)
        cmndArgsSpecDict = self.cmndArgsSpec()
####+END:
        self.cmndDocStr(f""" #+begin_org
** [[elisp:(org-cycle)][| *CmndDesc:* | ]]  Full processing: Process TaskJuggler file and convert Plan to image.
 Runs both tj3Process and tj3HtmlsToImages sequentially.
 Generates the reports directory, processes the .tjp file, and captures screenshots of all three HTML reports.
        #+end_org """)

        cmndArg = self.cmndArgsGet("0", cmndArgsSpecDict, argsList)
        tjpFilePath = cmndArg

        b_io.log.info(f"Running full processing for: {tjpFilePath}")

        # Step 1: Run tj3Process
        b_io.log.info(f"Step 1: Processing TaskJuggler file")
        
        processCmd = tj3Process(invocation=None)
        processOutcome = b.op.Outcome()
        processResult = processCmd.cmnd(
            rtInv=rtInv,
            cmndOutcome=processOutcome,
            argsList=[tjpFilePath]
        )

        if processResult.isProblematic():
            b_io.eh.error(f"Failed to process TaskJuggler file")
            return failed(cmndOutcome)

        # Step 2: Run tj3HtmlsToImages
        b_io.log.info(f"Step 2: Converting HTML reports to images")
        
        imageCmd = tj3HtmlsToImages(invocation=None)
        imageOutcome = b.op.Outcome()
        imageResult = imageCmd.cmnd(
            rtInv=rtInv,
            cmndOutcome=imageOutcome,
            argsList=[tjpFilePath]
        )

        if imageResult.isProblematic():
            b_io.eh.error(f"Failed to convert HTML reports to images")
            return failed(cmndOutcome)

        b_io.log.info(f"Full processing completed successfully")

        return cmndOutcome.set(
            opResults=f"Full processing completed for: {tjpFilePath}",
        )

####+BEGIN: b:py3:cs:method/args :methodName "cmndArgsSpec" :methodType "anyOrNone" :retType "bool" :deco "default" :argsList "self"
    """ #+begin_org
**  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  Mtd-T-anyOrNone [[elisp:(outline-show-subtree+toggle)][||]] /cmndArgsSpec/ deco=default  deco=default  [[elisp:(org-cycle)][| ]]
    #+end_org """
    @cs.track(fnLoc=True, fnEntry=True, fnExit=True)
    def cmndArgsSpec(self, ):
####+END:
        """  #+begin_org
*** [[elisp:(org-cycle)][| *cmndArgsSpec:* | ]] Path to TaskJuggler file
        #+end_org """

        cmndArgsSpecDict = cs.arg.CmndArgsSpecDict()
        cmndArgsSpecDict.argsDictAdd(
            argPosition="0",
            argName="tjpFilePath",
            argChoices=[],
            argDescription="Path to the TaskJuggler .tjp file for full processing"
        )

        return cmndArgsSpecDict
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*     [[elisp:(outline-show-subtree+toggle)][| _Main_: |]]  Framework DBlock  [[elisp:(org-shifttab)][<)]] E|
#+end_org """
####+END:

####+BEGIN: b:py3:cs:framework/main :csInfo "csInfo" :noCmndEntry "examples" :extraParamsHook "g_extraParams" :importedCmndsModules "g_importedCmndsModules"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  CsFrmWrk   [[elisp:(outline-show-subtree+toggle)][||]] =g_csMain= (csInfo, _examples_, g_extraParams, g_importedCmndsModules)
#+end_org """

if __name__ == '__main__':
    cs.main.g_csMain(
        csInfo=csInfo,
        noCmndEntry=examples,  # specify a Cmnd name
        extraParamsHook=g_extraParams,
        ignoreUnknownParams=False,  # True is for Uploaded Modules
        importedCmndsModules=g_importedCmndsModules,
    )

####+END:

####+BEGIN: b:py3:cs:framework/endOfFile :basedOn "classification"
""" #+begin_org
* [[elisp:(org-cycle)][| *End-Of-Editable-Text* |]] :: emacs and org variables and control parameters
#+end_org """

#+STARTUP: showall

### local variables:
### no-byte-compile: t
### end:
####+END:
