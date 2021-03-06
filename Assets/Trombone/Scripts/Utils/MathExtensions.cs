﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace MathExtensions {

    public static class MathAny {
        
        public static T ClampBetween<T>(this T val, T min, T max) where T : IComparable<T> {
            if (val.CompareTo(min) < 0) return min;
            else if (val.CompareTo(max) > 0) return max;
            else return val;
        }

        public static T Clamp<T>(T val, T min, T max) where T : IComparable<T> {
            if (val.CompareTo(min) < 0) return min;
            else if (val.CompareTo(max) > 0) return max;
            else return val;
        }

    }

    public static class Mathd {

        public static double Saturate(double val) {
            return val.ClampBetween(0.0, 1.0);
        }

        public static double MoveTowards(double current, double target, double amount) {
            if (current < target) return Math.Min(current + amount, target);
            else return Math.Max(current - amount, target);
        }

        public static double MoveTowards(double current, double target, double amountUp, double amountDown) {
            if (current < target) return Math.Min(current + amountUp, target);
            else return Math.Max(current - amountDown, target);
        }
    
    }

    public static class MathfExtensions {

        public static float Saturate(float val) {
            return val.ClampBetween(0.0f, 1.0f);
        }

        public static float MoveTowards(float current, float target, float amount) {
            if (current < target) return Mathf.Min(current + amount, target);
            else return Mathf.Max(current - amount, target);
        }

        public static float MoveTowards(float current, float target, float amountUp, float amountDown) {
            if (current < target) return Mathf.Min(current + amountUp, target);
            else return Mathf.Max(current - amountDown, target);
        }

    }

}
