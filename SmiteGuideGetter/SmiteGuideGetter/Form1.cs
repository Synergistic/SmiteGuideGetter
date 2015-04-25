using System;
using System.Resources;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmiteGuideGetter
{
    public partial class Form1 : Form
    {
        public List<string> Gods = new List<string>(){ "artemis", "arachne", "hades", "zeus", 
                                                       "anhur", "anubis", "bastet", "ra",
                                                       "sobek", "hel", "odin", "ymir",
                                                       "kukulkan", "guan yu", "he bo", "sun wukong",
                                                       "cupid", "agni", "bakasura", "kali", 
                                                       "vamana", "thor", "ares", "freya", "loki",
                                                       "bacchus", "xbalanque", "hercules", "vulcan", "neith",
                                                       "poseidon", "aphrodite", "apollo", "ne zha", "fenrir",
                                                       "isis", "athena", "hun batz", "chronos", 
                                                       "change", "tyr", "zhong kui", "thanatos", "mercury",
                                                       "ah muzen cab", "nu wa", "chaac", "geb", "nemesis",
                                                       "scylla", "ullr", "kumbhakarna", "osiris",
                                                       "janus", "rama", "serqet", "cabrakan", "sylvanus", "nox",
                                                       "ao kuang", "awilix", "hou yi", "bellona", "medusa"};

        public List<string> quickPickLinks = new List<string>(){
            "http://www.smitefire.com/smite/guide/here-piggy-piggy-conquest-adc-s2-5899",
            "http://www.smitefire.com/smite/guide/arachne-the-ultimate-jungle-guide-updated-for-season-2-updated-2-25-15-3965",
            "http://www.smitefire.com/smite/guide/hades-immortal-build-tested-amp-working-4121",
            "http://www.smitefire.com/smite/guide/zeus-overpower-3557",
            "http://www.smitefire.com/smite/guide/anhur-slayer-of-enemies-adc-updated-for-8th-jan-patch-3859",
            "http://www.smitefire.com/smite/guide/anubis-death-incarnate-patch-1-0-2436-85",
            "http://www.smitefire.com/smite/guide/bastet-scratch-the-game-i-jungle-amp-solo-guide-7776",
            "http://www.smitefire.com/smite/guide/glass-cannon-ra-2423",
            "http://www.smitefire.com/smite/guide/spring-loaded-crocodile-gun-conquest-support-s2-7611",
            "http://www.smitefire.com/smite/guide/cookies-bleep-cookies-hel-6015",
            "http://www.smitefire.com/smite/guide/odin-twist-and-raven-shout-dps-tank-builds-feb-22-2015-6103",
            "http://www.smitefire.com/smite/guide/dont-be-cold-come-on-in-updated-04-03-2015-s2-2430",
            "http://www.smitefire.com/smite/guide/burstmaster-kuku-7425",
            "http://www.smitefire.com/smite/guide/guan-yu-solo-bruiser-build-3122",
            "http://www.smitefire.com/smite/guide/he-bo-time-to-get-wet-and-knock-people-up-7",
            "http://www.smitefire.com/smite/guide/to-kill-a-mockingbird-of-nope-sun-wukong-solo-and-support-guide-updated-2-14-15-updated-for-season-2-4552",
            "http://www.smitefire.com/smite/guide/guide-to-a-successful-cupid-conquest-4398",
            "http://www.smitefire.com/smite/guide/make-it-rain-season-2-7361",
            "http://www.smitefire.com/smite/guide/bakasura-the-great-devourer-jungler-guide-updated-for-season-2-5756",
            "http://www.smitefire.com/smite/guide/headhunter-kali-jungle-build-in-depth-updated-2808",
            "http://www.smitefire.com/smite/guide/vamana-of-course-3258",
            "http://www.smitefire.com/smite/guide/thor-wielder-of-season-2s-mj-lnir-under-construction-7751",
            "http://www.smitefire.com/smite/guide/rage-of-war-ares-guide-30k-update-update-april-13-2015-5577",
            "http://www.smitefire.com/smite/guide/freya-valkyric-destruction-updated-2-6-2015-5320",
            "http://www.smitefire.com/smite/guide/the-low-key-god-4815",
            "http://www.smitefire.com/smite/guide/bacchus-support-guide-season-2-updated-4977",
            "http://www.smitefire.com/smite/guide/murder-by-moonlight-an-all-purpose-xbalanque-guide-3368",
            "http://www.smitefire.com/smite/guide/bringing-the-pain-in-the-solo-lane-with-herc-5668",
            "http://www.smitefire.com/smite/guide/you-shall-not-pass-7679",
            "http://www.smitefire.com/smite/guide/neith-not-your-average-hunter-updated-4-1-2015-4804",
            "http://www.smitefire.com/smite/guide/poseidon-season-2-5279",
            "http://www.smitefire.com/smite/guide/aphrodite-support-yes-support-7696",
            "http://www.smitefire.com/smite/guide/apollo-the-proper-way-to-play-5055",
            "http://www.smitefire.com/smite/guide/markis-guide-to-ne-zha-22-01-patch-1924",
            "http://www.smitefire.com/smite/guide/fenrir-the-ultimate-jungle-guide-updated-2-19-15-updated-for-season-2-5032",
            "http://www.smitefire.com/smite/guide/chicken-dinner-to-chicken-winner-conquest-mid-s2-5957",
            "http://www.smitefire.com/smite/guide/athena-support-guide-season-2-update-now-with-3vs3-gameplay-3834",
            "http://www.smitefire.com/smite/guide/hun-batz-jungle-guide-7875",
            "http://www.smitefire.com/smite/guide/ready-to-bend-some-real-time-with-chronos-2606",
            "http://www.smitefire.com/smite/guide/i-whip-my-hare-back-and-forth-conquest-solo-s2-5887",
            "http://www.smitefire.com/smite/guide/tearing-it-up-as-tyr-updated-combos-5271",
            "http://www.smitefire.com/smite/guide/who-you-gonna-call-god-buster-zhong-kui-5986",
            "http://www.smitefire.com/smite/guide/thanatos-hyper-carry-with-updating-and-guide-7562",
            "http://www.smitefire.com/smite/guide/mercury-the-swift-striker-jungle-7677",
            "http://www.smitefire.com/smite/guide/candyman-candyman-candyman-candyman-candyman-laning-joust-updated-for-season-2-4185",
            "http://www.smitefire.com/smite/guide/queen-of-the-burst-updated-2-15-15-6060",
            "http://www.smitefire.com/smite/guide/you-move-like-a-jaguar-axe-murdering-101-4911",
            "http://www.smitefire.com/smite/guide/geb-the-rolling-tank-season-2-update-5110",
            "http://www.smitefire.com/smite/guide/the-legislacerator-conquest-jungle-s2-5893",
            "http://www.smitefire.com/smite/guide/scylla-for-dummies-to-veterans-4346",
            "http://www.smitefire.com/smite/guide/ullr-the-terror-of-duo-lane-7691",
            "http://www.smitefire.com/smite/guide/kumbhakarna-the-cc-machine-5455",
            "http://www.smitefire.com/smite/guide/osiris-a-completely-broken-guide-on-sending-people-to-the-afterlife-4686",
            "http://www.smitefire.com/smite/guide/how-to-portal-with-janus-4877",
            "http://www.smitefire.com/smite/guide/rama-conquest-adc-5025",
            "http://www.smitefire.com/smite/guide/deadly-precision-8076",
            "http://www.smitefire.com/smite/guide/cabrakan-mountain-of-terror-updated-20-02-2015-5470",
            "http://www.smitefire.com/smite/guide/sylvanus-i-am-groot-detailed-ranked-guide-5568",
            "http://www.smitefire.com/smite/guide/jennifer-nyx-that-nox-updated-4-1-15-5809",
            "http://www.smitefire.com/smite/guide/ao-kuang-returns-to-the-solo-lane-7278",
            "http://www.smitefire.com/smite/guide/suku-the-lunartic-updated-4-15-2015-7368",
            "http://www.smitefire.com/smite/guide/whos-he-hou-yi-reference-only-7357",
            "http://www.smitefire.com/smite/guide/for-whom-the-bell-ona-tolls-conquest-solo-s2-7786",
            "http://www.smitefire.com/smite/guide/medusa-yes-looks-can-kill-updated-4-3-15-7982",
        };

        private string currentGod;
        private ResourceManager rm;

        public Form1()
        {
            InitializeComponent();
            rm = SmiteGuideGetter.Properties.Resources.ResourceManager;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentGod != null)
            {
                string guideUrl = "http://www.smitefire.com/smite/god/" + currentGod.Replace(" ", "-") + "-" + (Gods.IndexOf(currentGod) + 1);
                System.Diagnostics.Process.Start(guideUrl);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentGod != null)
            {
                System.Diagnostics.Debug.WriteLine(currentGod + " " + Gods.IndexOf(currentGod));
                string guideUrl = quickPickLinks[Gods.IndexOf(currentGod)];
                System.Diagnostics.Process.Start(guideUrl);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchedGod = textBox1.Text.ToLower();

            var match = Gods.FirstOrDefault(s => s.StartsWith(searchedGod));

            if (match != null)
            {
                pictureBox1.Image = (Image)rm.GetObject(match);
                currentGod = match;
            }
            else
            {
                pictureBox1.Image = (Image)rm.GetObject("error");
                currentGod = null;
            }
        }
    }
}
