using ExifLibrary;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace WF_test
{
    public partial class Form1 : Form
    {

        private bool photoShowing = false;  // Tells the program if a photo is showing or not
        private bool imageZoom = false; // This stores the stage of the image size property; tells the program if the image is zoomed in or not
        private string[] filePaths; // This will store the exact location of each photo in the folder
        private int currentPhoto;  // stores the index of the photo being displayed  
        private string[] metadata = new string [12]; // stores the current pictures meta data
        private string[] metadataStore = new string [12]; // stores a copy of a pictures metadata that can be used to override metadate in another picture.
        private string pictureFolderLocation; // Stores the folder location  

        private void loadPicture()
        {
           if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog.FileName);
                photoShowing = true;
                pictureFolderLocation = Path.GetDirectoryName(openFileDialog.FileName);  // Stores the picture's folder location
                filePaths = Directory.GetFiles(pictureFolderLocation, "*.jpg");
                // Only supports .jpg
                // Stores the index of the current photo so the program can go the next and previous photo in the folder  
                currentPhoto = Array.IndexOf(filePaths, openFileDialog.FileName);
                getMetadata();
            }
        }

        private MathEx.UFraction32 fractionBuilder(string tester)
        {
            //  Checks to see if the user has entered a valid fraction, if the user has then a fraction (MathEx.UFraction32) will be returned
            //  If it is not a valid fraction, then it will be returned empty
            bool workingValue;
            MathEx.UFraction32 fraction;
            if (tester.Contains("/"))
                if (tester.Contains("/"))
                {
                    string[] parts = tester.Split('/');
                    workingValue = Int32.TryParse(parts[0], out int numerator);
                    if (workingValue)
                    {
                        workingValue = Int32.TryParse(parts[1], out int denominator);
                        if (workingValue)
                        {
                            fraction = new MathEx.UFraction32((uint)numerator, (uint)denominator);
                            return fraction;
                        }
                    }
                }
            fraction = new MathEx.UFraction32((uint)0, (uint)0);
            return fraction;
        }

        private void cyclePicture(string direction) // Depending on whether the back or next button is pressed it displays the previous or next image in the folder on the screen
        {
            if (direction == "next")
            {
                if (currentPhoto+1 == filePaths.Length)
                {
                    currentPhoto = 0; // Loops the photos   
                }

                else
                {
                    currentPhoto += 1; 
                }
            }
            if (direction == "previous")
            {
                if (currentPhoto-1 < 0)
                {
                    currentPhoto = filePaths.Length-1; // Loops the photos
                }
                else
                {
                    currentPhoto -=1;
                }
            }
            pictureBox1.Load(filePaths[currentPhoto]);
            getMetadata();
        }
        private void getMetadata()
        {

            // The following gets and stores the photo’s data. See the link blow for more information.
            // http://oozcitak.github.io/exiflibrary/articles/JPEGMetadata.html

            var picture = ImageFile.FromFile(filePaths[currentPhoto]);

            var temp0 = picture.Properties.Get<ExifDateTime>(ExifTag.DateTime); // Date and time
            if (temp0 == null) { metadata[0] = "Data not found"; }
            else { metadata[0] = temp0.ToString(); }
           

            var temp1 = picture.Properties.Get<ExifUShort>(ExifTag.ISOSpeedRatings); // ISO
            if (temp1 == null) { metadata[1] = "Data not found"; }
            else { metadata[1] = temp1.ToString(); }  

            var temp2 = picture.Properties.Get<ExifURational>(ExifTag.ApertureValue); // Aperture // 
            if (temp2 == null) { metadata[2] = "Data not found"; }
            else { metadata[2] = temp2.ToString(); }

            var temp3 = picture.Properties.Get<ExifURational>(ExifTag.ExposureTime); // Exposure
            if (temp3 == null) { metadata[3] = "Data not found"; }
            else { metadata[3] = temp3.ToString(); }

            var temp4 = picture.Properties.Get<ExifURational>(ExifTag.FocalLength); // FocalLength
            if (temp4 == null) { metadata[4] = "Data not found"; }
            else { metadata[4] = temp4.ToString(); }

            var temp5 = picture.Properties.Get<ExifAscii>(ExifTag.Model); // Camera Model
            if (temp5 == null) { metadata[5] = "Data not found"; }
            else { metadata[5] = temp5.ToString(); }

            var temp6 = picture.Properties.Get<ExifAscii>(ExifTag.Make); // Camera manufacturer
            if (temp6 == null) { metadata[6] = "Data not found"; }
            else { metadata[6] = temp6.ToString(); }

            var temp7 = picture.Properties.Get<ExifEnumProperty<Flash>>(ExifTag.Flash); // Flash
            if (temp7 == null) { metadata[7] = "Data not found"; }
            else { metadata[7] = temp7.ToString(); }

            var temp8 = picture.Properties.Get<ExifAscii>(ExifTag.LensModel); // Lens model
            if (temp8 == null) { metadata[8] = "Data not found"; }
            else { metadata[8] = temp8.ToString(); }

            var temp9 = picture.Properties.Get<ExifAscii>(ExifTag.Copyright); // Copy right information
            if (temp9 == null) { metadata[9] = "Data not found"; }
            else { metadata[9] = temp9.ToString(); }

            Bitmap bmp = new Bitmap(filePaths[currentPhoto]);
            metadata[10] = (bmp.Width + " x " + bmp.Height); // Resolution

            metadata[11] = Path.GetFileName(filePaths[currentPhoto]); // Photo name
            showValues(metadata);
        }

        private void showValues(string[] array) // Displays the following information on screen
        {
            cameraMTextBox.Text = array[6]; // Camera manufacturer
            exposureTextBox.Text = array[3]; // Exposure
            flashTextBox.Text = array[7]; // Flash
            ISOTextBox.Text = array[1]; // ISO
            apertureTextBox.Text = array[2]; // Aperture
            FLtextBox.Text = array[4]; // FocalLength
            lensModelTextBox.Text = array[8]; // Lens model
            copyRightTextBox.Text = array[9]; // Copy right information
            DTTextBox.Text = array[0]; // Date and time
            cameraModelTextBox.Text = array[5]; // Camera Model
            resolutionValue.Text = metadata[10]; // Resolution  // Keeps the same name and file resolution 
            photoNameValue.Text = metadata[11]; // Photo name


        }

        private string[] setValues() //Saves the values in the text fields to an array
        {
            string[] array = new string[12];
            array[6] = cameraMTextBox.Text; // Camera manufacturer
            array[3] = exposureTextBox.Text;  // Exposure
            array[7] = flashTextBox.Text; // Flash
            array[1] = ISOTextBox.Text; // ISO 
            array[2] = apertureTextBox.Text; // aperture
            array[4] = FLtextBox.Text; // FocalLength
            array[8] = lensModelTextBox.Text; // // Lens model
            array[9] = copyRightTextBox.Text; // Copy right information
            array[0] = DTTextBox.Text; // Date and time
            array[5] = cameraModelTextBox.Text; // Camera Model
            array[10] = array[10]; // Resolution // Keeps the same name and file resolution 
            array[11] = array[11]; // Photo name

            return array;
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // Resizes the buttons with the forum
            // All ratios were found by comparing the object’s size to the original size of the form size at start (916, 469)

            int width = (this.Width - 216) / 4;
            // The default amount of empty space spread evenly between 4 buttons is 216 when the width is 880 pixels
            // Subtracting that from the new width and divided by five gives us the button size 

            int space = (this.Width - (width * 4)) / 5;
            //Subtracting the amount of space the buttons occupy from the width then dividing by five gives us the space between the buttons.

            int shift = width + 36; // The amount of space each button shifts

            int y = (panel1.Height - back.Height)/2; // Centers the button in the available space

            // Set's the "Back" button position and size
            back.Width = width;
            back.Location = new Point(space, y);

            // Set's the "Open new picture" button position and size
            openPicture.Width = width;
            openPicture.Location = new Point((space + shift), y);

            // Set's the "Fit image to screen" button position and size
            changeImageView.Width = width;
            changeImageView.Location = new Point((space + 2 * shift), y);


            //   // Set's the "Next" button position and size
            next.Width = width;
            next.Location = new Point((space + 3 * shift), y);

            // Makes the picture box take up half of the forum
            pictureBox1.Width = this.Width / 2;
            pictureBox1.Height = this.Height;

            // Resizes the metadata controls 

            int availableSpace = this.Width / 2; // We only want the controls to show up on the second half of the form


            // Resizes the metadata control buttons

            width = (availableSpace - 78) /4; // 78 is the default total default amount of space between the buttons at  458 pixels (for width)
            space = ((availableSpace - width * 4) / 5); // space between the buttons
            shift = width + 10; // The amount of space each button shifts
            if (this.Height > 700)
            {
                y = Convert.ToInt32(this.Height * 0.92) - 100; // Keeps the buttons spaced from the bottom at a constant rate
            }
            else { y = Convert.ToInt32(this.Height * 0.92 - 80); } // Prevents a large white space under the buttons

            save.Width = width;
            save.Location = new Point((space + availableSpace), y);

            showOriginal.Width = width;
            showOriginal.Location = new Point((space + shift + availableSpace), y);

            copyValues.Width = width;
            copyValues.Location = new Point((space + 2 * shift + availableSpace), y);

            pasteValues.Width = width;
            pasteValues.Location = new Point((space + 3 * shift + availableSpace), y);


            // Resizes the metadata labels and input / output fields
            //Here we are using ratios to get the value of the first term then we can find and set the values of the rest


            int availableVerticalSpace = this.Height - (this.Height - save.Location.Y) - photoInfoTopPanel.Height; // The amount of space in the panel (not including the buttons)
            int height = Convert.ToInt32(this.Height / 18.76); // Ratio to get the height location of camera manufacturer
            //Since every label is the same size we can use this as the height for every label  
            int x = (this.Width / 2) + 8;
            int verticalSpace = ((availableVerticalSpace - (10*height)) / 12) + 34; // The amount of vertical space between buttons 

            cameraMLabel.Location = new Point(x, verticalSpace);

            cameraModelLabel.Location = new Point(x, (cameraMLabel.Location.Y + verticalSpace));

            lensModelLabel.Location = new Point(x, (cameraModelLabel.Location.Y + verticalSpace));

            DTLabel.Location = new Point(x, (lensModelLabel.Location.Y + verticalSpace));

            copyRightLabel.Location = new Point(x, (DTLabel.Location.Y + verticalSpace));

            flashLabel.Location = new Point(x, (copyRightLabel.Location.Y + verticalSpace));

            ISOLabel.Location = new Point(x, (flashLabel.Location.Y + verticalSpace));

            Aperturelabel.Location = new Point(x, (ISOLabel.Location.Y + verticalSpace));

            FLLabel.Location = new Point(x, (Aperturelabel.Location.Y + verticalSpace));

            exposureLabel.Location = new Point(x, (FLLabel.Location.Y + verticalSpace));

            //  x = cameraMLabel.Location.X + 219; // The input / output text box always starts 219 pixels from the identifier labels
            x = (cameraMLabel.Location.X + Convert.ToInt32(this.Width/ 4.18)) - (this.Width / 76); // The distance between the labels and text boxes scales up with the form
            width = Convert.ToInt32(this.Width / 4.36);

            cameraMTextBox.Width = width;
            cameraMTextBox.Location = new Point(x, verticalSpace);

            cameraModelTextBox.Width = width;
            cameraModelTextBox.Location = new Point(x, (cameraMTextBox.Location.Y + verticalSpace));

            lensModelTextBox.Width = width;
            lensModelTextBox.Location = new Point(x, (cameraModelTextBox.Location.Y + verticalSpace));

            DTTextBox.Width = width;
            DTTextBox.Location = new Point(x, (lensModelTextBox.Location.Y + verticalSpace));

            copyRightTextBox.Width = width;
            copyRightTextBox.Location = new Point(x, (DTTextBox.Location.Y + verticalSpace));

            flashTextBox.Width = width;
            flashTextBox.Location = new Point(x, (copyRightTextBox.Location.Y + verticalSpace));

            ISOTextBox.Width = width;
            ISOTextBox.Location = new Point(x, (flashTextBox.Location.Y + verticalSpace));

            apertureTextBox.Width = width;
            apertureTextBox.Location = new Point(x, (ISOTextBox.Location.Y + verticalSpace));

            FLtextBox.Width = width;
            FLtextBox.Location = new Point(x, (apertureTextBox.Location.Y + verticalSpace));

            exposureTextBox.Width = width;
            exposureTextBox.Location = new Point(x, (FLtextBox.Location.Y + verticalSpace));

        }


        // If a photo is not showing, then clicking any of the buttons will open the file dialog
        private void next_Click(object sender, EventArgs e)
        {
            if (photoShowing != true)
            {
                loadPicture();
            }
            else
            {
                cyclePicture("next");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (photoShowing != true)
            {
                loadPicture();
            }
            else
            {
                cyclePicture("previous");
            }
        }

        private void openPicture_Click(object sender, EventArgs e)
        {
            loadPicture();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = this.Width - 1; // Triggers the resize events that spaces out the controls 
            this.Width = this.Width + 1; 
        }

        private void changeImageView_Click(object sender, EventArgs e)
        {

            if (photoShowing != true)
            {
                loadPicture();
            }
            else
            {
                if (imageZoom != true) // The button will toggle between zoom and image stretch size modes
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    changeImageView.Text = "Show original";
                    imageZoom = true;
                }
                else
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    changeImageView.Text = "Fit image to screen";
                    imageZoom = false;
                }
            }
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void showOriginal_Click(object sender, EventArgs e)
        {
            if (photoShowing != true)
            {
                loadPicture();
            }
            else
            {
                showValues(metadata); // Clears out what the user has typed and shows original photo metadata 

            }
        }

        private void copyValues_Click(object sender, EventArgs e)
        {
            if (photoShowing != true)
            {
                loadPicture();
            }
            else
            {
                metadataStore = setValues(); // Makes and stores a copy of the metadata
            }

        }

        private void pasteValues_Click(object sender, EventArgs e)
        {
            if (photoShowing != true)
            {
                loadPicture();
            }
            else
            {
                showValues(metadataStore);
            }

        }

        private void save_Click(object sender, EventArgs e)
        {
            if (photoShowing != true)
            {
                loadPicture();
            }
            else
            {
                // Gets the values form the text fields 
                var picture = ImageFile.FromFile(filePaths[currentPhoto]);
                string[] data = setValues();



                // Checks to see if the user entered a valid number and sets it accordingly
                bool workingValue;
                string tester;
                // If the fractionBuilder returns this exact value, then the fraction is not possible
                MathEx.UFraction32 testFraction = new MathEx.UFraction32(0, 0);
                MathEx.UFraction32 fractionStorage = new MathEx.UFraction32(0, 0); // Used to store fraction values


                // Date and time
                workingValue = DateTime.TryParse(data[0], out DateTime dateTime);
                if (workingValue)
                {
                    if (picture.Properties[ExifTag.DateTime] != null)
                    {
                        picture.Properties[ExifTag.DateTime].Value = dateTime;
                    }
                }


                //ISO
                workingValue = Int32.TryParse(data[1], out int ISO);
                if (workingValue)
                {
                    if (picture.Properties[ExifTag.ISOSpeedRatings] != null)
                    {
                        picture.Properties[ExifTag.ISOSpeedRatings].Value = (ushort)ISO;
                    }
                }


                // Aperture
                fractionStorage = fractionBuilder(data[2]);
                if (fractionStorage != testFraction)
                {
                    if (picture.Properties[ExifTag.ApertureValue] != null)
                    {
                        picture.Properties[ExifTag.ApertureValue].Value = fractionStorage;
                    }
                }


                //Exposure time
                fractionStorage = fractionBuilder(data[3]);
                if (fractionStorage != testFraction)
                {
                    if(picture.Properties[ExifTag.ExposureTime] != null)
                    {
                        picture.Properties[ExifTag.ExposureTime].Value = fractionStorage;
                    }
                }


                // Focal length
                fractionStorage = fractionBuilder(data[4]);
                if (fractionStorage != testFraction)
                {
                    if (picture.Properties[ExifTag.FocalLength] != null)
                    {
                        picture.Properties[ExifTag.FocalLength].Value = fractionStorage;
                    }
                }


                // Camera model
                if (picture.Properties[ExifTag.Model] != null)
                {
                    picture.Properties[ExifTag.Model].Value = data[5];
                }


                // Camera manufacturer
                if (picture.Properties[ExifTag.Make] != null)
                {
                    picture.Properties[ExifTag.Make].Value = data[6];
                }


                // Flash
                tester = data[7];
                if (picture.Properties[ExifTag.Flash] != null)
                {
                    if (tester == "AutoMode") { picture.Properties[ExifTag.Flash].Value =  Flash.AutoMode; }
                    else if (tester == "CompulsoryFlashMode") { picture.Properties[ExifTag.Flash].Value = Flash.CompulsoryFlashMode; }
                    else if (tester == "FlashDidNotFire") { picture.Properties[ExifTag.Flash].Value = Flash.FlashDidNotFire; }
                    else if (tester == "FlashFirede") { picture.Properties[ExifTag.Flash].Value = Flash.FlashFired; }
                    else if (tester == "NoFlashFunction") { picture.Properties[ExifTag.Flash].Value = Flash.NoFlashFunction; }
                    else if (tester == "RedEyeReductionMode") { picture.Properties[ExifTag.Flash].Value = Flash.RedEyeReductionMode; }
                    else if (tester == "StrobeReturnLightDetected") { picture.Properties[ExifTag.Flash].Value = Flash.StrobeReturnLightDetected; }
                    else if (tester == "StrobeReturnLightNotDetected") { picture.Properties[ExifTag.Flash].Value = Flash.StrobeReturnLightNotDetected; }
                    else { }
                }


                // Lens model
                if (picture.Properties[ExifTag.LensModel] != null)
                {
                    picture.Properties[ExifTag.LensModel].Value = data[8];
                }


                // Copy right information
                if (picture.Properties[ExifTag.Copyright] != null)
                {
                    picture.Properties[ExifTag.Copyright].Value = data[9];
                }
            


                // This stores the photo in the edited images folder
                string newLocation = pictureFolderLocation + @"\Edited_Images\";

                if (!Directory.Exists(newLocation)) // Creates the folder if it is not there
                {
                    back.Text = "Not found";
                    Directory.CreateDirectory(newLocation);
                }

                newLocation = newLocation + metadata[11];
                picture.Save(newLocation); 
                    

                // clena up code
                // check over all of the programs code *****************
                // beta test it
                // fix bete testing bugs
                // do the guthib file experment
                // make a weite up using the github readme thing
                // figure out how to compile it over CMD
                // remove ucelsss packages
                // test compile it on moms computer
                // compile it
                // upload this and a link to the precompiled edition to my github

            }
        }

        private void photoNameValue_Click(object sender, EventArgs e)
        {

        }

        private void resolutionValue_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (photoShowing != true)
            {
                loadPicture();
            }
        }

        private void resolutionLabel_Click(object sender, EventArgs e)
        {

        }

        private void cameraMTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void photoNamelabel_Click(object sender, EventArgs e)
        {

        }

        private void copyRightTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void copyRightLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
