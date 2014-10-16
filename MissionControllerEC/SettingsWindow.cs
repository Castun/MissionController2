﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Text.RegularExpressions;

namespace MissionControllerEC
{
    public partial class MissionControllerEC
    {
        private string hireme;
        private string insuranceme;
        private void drawSettings(int id)
        {
            GUI.skin = HighLogic.Skin;
            GUILayout.BeginVertical();
                     
            GUILayout.Space(10);
            GUILayout.BeginHorizontal();
            GUILayout.Box("Hire Kerbal Cost",MCE_ScenarioStartup.StyleBold, GUILayout.Width(300));
            hireme = settings.HireCost.ToString();
            hireme = Regex.Replace(GUILayout.TextField(hireme), "[^.0-9]", "");                        
            settings.HireCost = double.Parse(hireme);
            GUILayout.EndHorizontal();

            GUILayout.Space(10);
            GUILayout.BeginHorizontal();
            GUILayout.Box("Kerbal Insurance Cost",MCE_ScenarioStartup.StyleBold, GUILayout.Width(300));
            insuranceme = settings.DeathInsurance.ToString();
            insuranceme = Regex.Replace(GUILayout.TextField(insuranceme), "[^.0-9]", "");           
            settings.DeathInsurance = double.Parse(insuranceme);
            GUILayout.EndHorizontal();

            GUILayout.Space(10);
            GUILayout.BeginHorizontal();
            GUILayout.Box("Flight Help On (Apa,PeA,Orbital Period)",MCE_ScenarioStartup.StyleBold, GUILayout.Width(300));
            GUILayout.Box("" + SaveInfo.MessageHelpers, MCE_ScenarioStartup.styleBlueBold, GUILayout.Width(75));
            SaveInfo.MessageHelpers = GUILayout.Toggle(SaveInfo.MessageHelpers, "Set", GUILayout.Width(25));
            GUILayout.EndHorizontal();

            GUILayout.Space(10);
            GUILayout.BeginHorizontal();
            GUILayout.Box("Rescue Kerbal Contracts Off (Needs Restart)",MCE_ScenarioStartup.StyleBold, GUILayout.Width(300));
            GUILayout.Box("" + settings.NoRescueKerbalContracts, MCE_ScenarioStartup.styleBlueBold, GUILayout.Width(75));
            settings.NoRescueKerbalContracts = GUILayout.Toggle(settings.NoRescueKerbalContracts, "Set", GUILayout.Width(25));
            GUILayout.EndHorizontal();

            GUILayout.Space(10);
            GUILayout.BeginHorizontal();
            GUILayout.Box("Part Test Contracts Off (Needs Restart)", MCE_ScenarioStartup.StyleBold, GUILayout.Width(300));
            GUILayout.Box("" + settings.NoPartTestContracts, MCE_ScenarioStartup.styleBlueBold, GUILayout.Width(75));
            settings.NoPartTestContracts = GUILayout.Toggle(settings.NoPartTestContracts, "Set", GUILayout.Width(25));
            GUILayout.EndHorizontal();

            GUILayout.Space(10);
            GUILayout.BeginHorizontal();
            GUILayout.Box("No MCE Satellite Contracts", MCE_ScenarioStartup.StyleBold, GUILayout.Width(300));
            GUILayout.Box("" + SaveInfo.NoSatelliteContracts, MCE_ScenarioStartup.styleBlueBold, GUILayout.Width(75));
            SaveInfo.NoSatelliteContracts = GUILayout.Toggle(SaveInfo.NoSatelliteContracts, "Set", GUILayout.Width(25));
            GUILayout.EndHorizontal();

            GUILayout.Space(10);
            GUILayout.BeginHorizontal();
            GUILayout.Box("No MCE Orbital Period Satellite Contracts", MCE_ScenarioStartup.StyleBold, GUILayout.Width(300));
            GUILayout.Box("" + SaveInfo.NoOrbitalPeriodcontracts, MCE_ScenarioStartup.styleBlueBold, GUILayout.Width(75));
            SaveInfo.NoOrbitalPeriodcontracts = GUILayout.Toggle(SaveInfo.NoOrbitalPeriodcontracts, "Set", GUILayout.Width(25));
            GUILayout.EndHorizontal();

            GUILayout.Space(10);
            GUILayout.BeginHorizontal();
            GUILayout.Box("No MCE Repair Contracts", MCE_ScenarioStartup.StyleBold, GUILayout.Width(300));
            GUILayout.Box("" + SaveInfo.NoRepairContracts, MCE_ScenarioStartup.styleBlueBold, GUILayout.Width(75));
            SaveInfo.NoRepairContracts = GUILayout.Toggle(SaveInfo.NoRepairContracts, "Set", GUILayout.Width(25));
            GUILayout.EndHorizontal();

            GUILayout.Space(10);
            GUILayout.BeginHorizontal();
            GUILayout.Box("No MCE Orbital Research Contracts", MCE_ScenarioStartup.StyleBold, GUILayout.Width(300));
            GUILayout.Box("" + SaveInfo.NoOrbitalResearchContracts, MCE_ScenarioStartup.styleBlueBold, GUILayout.Width(75));
            SaveInfo.NoOrbitalResearchContracts = GUILayout.Toggle(SaveInfo.NoOrbitalResearchContracts, "Set", GUILayout.Width(25));
            GUILayout.EndHorizontal();

            GUILayout.Space(10);
            GUILayout.BeginHorizontal();
            GUILayout.Box("No MCE Lander Research Contracts", MCE_ScenarioStartup.StyleBold, GUILayout.Width(300));
            GUILayout.Box("" + SaveInfo.NoLanderResearchContracts, MCE_ScenarioStartup.styleBlueBold, GUILayout.Width(75));
            SaveInfo.NoLanderResearchContracts = GUILayout.Toggle(SaveInfo.NoLanderResearchContracts, "Set", GUILayout.Width(25));
            GUILayout.EndHorizontal();
           
            GUILayout.Space(10);
            GUILayout.BeginHorizontal();
            GUILayout.Box("Set MCE Revert On (Needs Restart)", MCE_ScenarioStartup.StyleBold, GUILayout.Width(300));
            GUILayout.Box("" + settings.RevertOn, MCE_ScenarioStartup.styleBlueBold, GUILayout.Width(75));
            settings.RevertOn = GUILayout.Toggle(settings.RevertOn, "Set Revert", GUILayout.Width(25));
            GUILayout.EndHorizontal();

            GUILayout.Space(10);
            GUILayout.BeginHorizontal();
            GUILayout.Box("Set Debug Menu On", MCE_ScenarioStartup.StyleBold, GUILayout.Width(300));
            GUILayout.Box("" + settings.DebugMenu, MCE_ScenarioStartup.styleBlueBold, GUILayout.Width(75));
            settings.DebugMenu = GUILayout.Toggle(settings.DebugMenu, "Set Debug", GUILayout.Width(25));
            GUILayout.EndHorizontal();

            GUILayout.EndVertical();
            if (GUILayout.Button("Exit Save Settings"))
            {
                MCE_ScenarioStartup.ShowSettingsWindow = false;
                settings.Save();
                settings.Load();
            }

            if (!Input.GetMouseButtonDown(1))
            {
                GUI.DragWindow();
            }
        }
    }
}