﻿using OpenQA.Selenium;
using Browser;
using System.Threading;

namespace Search
{
    class SDotabuff
    {
        public static readonly string url = "https://www.dotabuff.com/heroes/";
        public static string getData(in string hero, in int index)
        {
            var br = new Brows();
            br.setLink(url+hero);
            var web = br.getDriver();
            string tx = string.Empty;
            try
            {
                tx = web.FindElement(by: By.XPath("/html/body/h2")).Text;
            }
            catch (System.Exception ex)
            {
                if(ex.Message.Contains("no such element")) tx = string.Empty;
            }
            if (tx != string.Empty)
            {
                br.quit();
                return "There's no such hero.";
            }
            else
            {
                web.FindElement(
                    by: By.XPath("/html/body/div[2]/div[2]/div[3]/div[3]/div[2]/div/nav/ul/li[2]/a")).Click();
                Thread.Sleep(50);
                var abilities = web.FindElement(
                    by: By.XPath("/html/body/div[2]/div[2]/div[3]/div[3]/div[1]/div[2]/div"))
                    .FindElements(by: By.TagName("img"));
                var groups = web.FindElement(
                    by: By.XPath("/html/body/div[2]/div[2]/div[3]/div[4]"))
                    .FindElements(by: By.TagName("section"));
                var items = groups[index+2].FindElement(by: By.ClassName("top-right"))
                    .FindElement(by: By.ClassName("kv")).FindElements(by: By.TagName("a"));
                string text;
                var info = groups[index + 2].FindElements(by: By.ClassName("group"))[1].FindElements(by: By.TagName("div"));
                int shift = 0;
                if (info.Count == 7) shift++;
                text = info[0 + shift].Text;
                text += " " + info[1 + shift].Text;
                text += " " + info[5 + shift].Text;
                text += "\n" + info[2 + shift].Text;
                tx += $"{text}\n\nItem build\n";
                foreach (var item in items)
                {
                    text = item.GetAttribute("href").Remove(0, 31).Replace('-', ' ');
                    tx += $"{text}\n";
                }
                var abBuild = web.FindElement(
                    by: By.XPath($"/html/body/div[2]/div[2]/div[3]/div[4]/section[{index + 3}]/article/div/div[4]")).FindElements(
                    by: By.TagName("img"));
                string talents = string.Empty;
                tx += "\nAbilities build\n";
                foreach (var item in abBuild)
                {
                    foreach (var item2 in abilities)
                    {
                        if (item.GetAttribute("src") == item2.GetAttribute("src"))
                        {
                            if (abilities.IndexOf(item2) < 4)
                            {
                                tx += $"{abilities.IndexOf(item2) + 1} ";
                            }
                            else if (abilities.IndexOf(item2) == 4)
                            {
                                tx += $"t ";
                                talents += $"{item.GetAttribute("alt").Remove(0, 8)}\n";
                            }
                        }
                    }
                }
                tx += $"\n\nTalents\n{talents}";
                br.quit();
                return tx;
            }
        }
    }
}