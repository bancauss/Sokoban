﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Sokoban.Controller
{
    public class GameController
    {
        private InputView _inputView;
        private OutputView _outputView;
        private Maze _maze;
        private bool _gameIsFinish;



        public GameController()
        {
            this._inputView = new InputView();
            this._outputView = new OutputView();
            this._gameIsFinish = false;
            this.StartGame();

        }

        private void StartGame()
        {
            int num = 1;

            //first view of the game
            _outputView.ShowGameInfo();

            int mazeNumber = 0;
            Input askInput;
            bool inputIsCorrect = false;



            while (inputIsCorrect != true)
            {
                mazeNumber = _inputView.AskToSelectMazeInput();

                if (mazeNumber == -1)
                {
                    case "s":
                        Environment.Exit(0);
                        return;
                    case "1":
                        _maze = new Maze(1);
                        return;
                    case "2":
                        _maze = new Maze(2);

                        return;
                    case "3":

                        _maze = new Maze(3);

                        return;
                    case "4":

                        _maze = new Maze(4);

                        return;

                    default:
                        _inputView.ShowWrongInput();
                        break;
                }

            }

            while (_gameIsFinish != true)
            {
                inputIsCorrect = false;
                _outputView.ShowGameProces(_maze);
        

                while (inputIsCorrect != true)
                {
                    askInput = _inputView.AskGameControlInput();

                    switch (askInput)
                    {
                        case Input.S:
                            _gameIsFinish = true;
                            inputIsCorrect = true;
                            Environment.Exit(0);
                            break;
                        case Input.R:
                            _maze.ResetMaze();

                            inputIsCorrect = true;
                            break;
                        case Input.Up:

                            inputIsCorrect = true;
                            break;
                        case Input.Down:

                            inputIsCorrect = true;
                            break;
                        case Input.Left:

                            inputIsCorrect = true;
                            break;
                        case Input.Right:

                            inputIsCorrect = true;
                            break;
                        default:
                            _inputView.ShowWrongInput();
                            inputIsCorrect = false;
                            break;

                    }

                }
              
               
            }



           





            _inputView.AskToPressKeyToStartOver();
            this.StartGame();

        }






        private void MoveTruck(Input direction)
        {

            switch (direction)
            {
                case Input.Up:

                    break;
                case Input.Down:

                    break;
                case Input.Right:

                    break;
                case Input.Left:

                    break;


            }



        }





    }
}
