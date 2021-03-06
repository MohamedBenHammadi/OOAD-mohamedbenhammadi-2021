﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfEscapeGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Room currentRoom; // will become useful in later versions

        public MainWindow()
        {
            InitializeComponent();

            // define room
            Room room1 = new Room(
            "bedroom",
            "I seem to be in a medium sized bedroom. There is a locker to the left, a nice rug on the floor, and a bed to the right. ");
            Room LivingRoom = new Room(
           " living room",
           "I seem to be in a medium sized sofa. we can chill on the sofa. ");
            Room ComputerRoom = new Room(
           "computer room",
           "wow what a computer, lets play warzone ");


            // define door

            Door computerDoor = new Door("green door", "you have acces to the living room");
            Door livingDoom1 = new Door("linig door 1", "door to computer room");
            Door livingDoom2 = new Door("living door 2 ", "you can stop the game");
            Door bedRoomDoor = new Door("blue door", "you can go to the living roo");

            // define items
            Item key1 = new Item(
            "small silver key",
            "A small silver key");

            Item key2 = new Item("large key", "A large key. Could this be my way out? ");
            Item locker = new Item(
            "locker",
            "A locker. I wonder what's inside. "
            );
            locker.HiddenItem = key2;
            locker.IsLocked = true;
            locker.Key = key1;
            Item bed = new Item(
            "bed",
            "Just a bed. I am not tired right now. "
            );
            bed.HiddenItem = key1;
            Item stoel = new Item("stoel", "iets waar je kan erop zitten", false);
            Item poster = new Item("poster", "een grote foto");
            Item sofa = new Item("sofa", "iets waar je erop kan chillen");
            Item plant = new Item("plant", "een decor object");
            Item bureau = new Item("bureau", "meubleachtige object");
            Item Kader = new Item("Kader", "iets waar je kan een foto op hangen ");




            // setup bedroom
            room1.Items.Add(new Item(
            "floor mat",
            "A bit ragged floor mat, but still one of the most popular designs. ", false
            ));
            room1.Items.Add(bed);
            room1.Items.Add(locker);
            room1.Items.Add(stoel);
            room1.Items.Add(poster);
            room1.Door.Add(computerDoor);

            LivingRoom.Items.Add(sofa);
            LivingRoom.Items.Add(plant);

            ComputerRoom.Items.Add(bureau);
            ComputerRoom.Items.Add(Kader);


            // start game
            currentRoom = room1;
            lblMessage.Content = "I am awake, but cannot remember who I am!? Must have been a hell of a party last night... ";
            txtRoomDesc.Text = currentRoom.Description;
            UpdateUI();



        }

        private void UpdateUI()
        {
            lstRoomItems.Items.Clear();
            lstRoomDoors.Items.Clear();
            foreach (Item itm in currentRoom.Items)
            {
                lstRoomItems.Items.Add(itm);
            }
            foreach (Door drs in currentRoom.Door)
            {
                lstRoomDoors.Items.Add(drs);
            }

            string room = currentRoom.Name;
            imagesRoom.Source = new BitmapImage(new Uri($"img/{room}.png", UriKind.Relative));

        }

        private void LstItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnCheck.IsEnabled = lstRoomItems.SelectedValue != null; // room item selected
            btnPickUp.IsEnabled = lstRoomItems.SelectedValue != null; // room item selected
            btnUseOn.IsEnabled = lstRoomItems.SelectedValue != null && lstMyItems.SelectedValue != null; // room item //and picked up item selected
            btnDrop.IsEnabled = lstMyItems.SelectedValuePath != null;
        }

        private void BtnCheck_Click(object sender, RoutedEventArgs e)
        {
            // 1. find item to check
            Item roomItem = (Item)lstRoomItems.SelectedItem;
            // 2. is it locked?
            if (roomItem.IsLocked)
            {
                lblMessage.Content = $"{roomItem.Description}It is firmly locked. ";
                return;
            }
            // 3. does it contain a hidden item?
            Item foundItem = roomItem.HiddenItem;
            if (foundItem != null)
            {
                lblMessage.Content = $"Oh, look, I found a {foundItem.Name}. ";
                lstMyItems.Items.Add(foundItem);
                roomItem.HiddenItem = null;
                return;
            }
            // 4. just another item; show description
            lblMessage.Content = roomItem.Description;
        }

        private void BtnUseOn_Click(object sender, RoutedEventArgs e)
        {
            // 1. find both items
            Item myItem = (Item)lstMyItems.SelectedItem;
            Item roomItem = (Item)lstRoomItems.SelectedItem;
            // 2. item doesn't fit
            Random r = new Random();
            if (roomItem.Key != myItem)
            {
                lblMessage.Content = RandomMessageGenerator.GetRandomMessage(RandomMessageGenerator.MessageType.type1);
                return;
            }
            // 3. item fits; other item unlocked
            roomItem.IsLocked = false;
            roomItem.Key = null;
            lstMyItems.Items.Remove(myItem);
            lblMessage.Content = $"I just unlocked the {roomItem.Name}!";
        }


        private void BtnPickUp_Click(object sender, RoutedEventArgs e)
        {
            // 1. find selected item
            Item selItem = (Item)lstRoomItems.SelectedItem;
            // 2. add item to your items list
            if (selItem.IsPortable != false)
            {
                lblMessage.Content = $"I just picked up the {selItem.Name}. ";
                lstMyItems.Items.Add(selItem);
                lstRoomItems.Items.Remove(selItem);
                currentRoom.Items.Remove(selItem);
            }
            else
            {
                lblMessage.Content = $"I cant pick the {selItem.Name}. ";
            }
        }

        private void btnDrop_Click(object sender, RoutedEventArgs e)
        {
            // 1. find selected item
            Item dropItem = (Item)lstMyItems.SelectedItem;
            // 2. drop item to your room
            lblMessage.Content = $"I just droped up the {dropItem.Name}. ";
            lstRoomItems.Items.Add(dropItem);
            lstMyItems.Items.Remove(dropItem);
            currentRoom.Items.Remove(dropItem);
        }

        private void btnOpenWith_Click(object sender, RoutedEventArgs e)
        {
            Item key = (Item)lstMyItems.SelectedItem;
            Door door = (Door)lstRoomDoors.SelectedItem;
            if (door.Key != key)
            {
                lblMessage.Content = RandomMessageGenerator.GetRandomMessage(RandomMessageGenerator.MessageType.type1);
                return;
            }
            door.IsLocked = false;
            door.Key = null;
            lstMyItems.Items.Remove(key);
            lblMessage.Content = $"I just unlocked the {door.Name}!";
            btnEnter.IsEnabled = true;
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
