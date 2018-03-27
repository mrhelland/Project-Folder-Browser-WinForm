﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFolderCore.DataTypes {

    public class TreeNode<T> {
        private readonly T _value;
        private readonly List<TreeNode<T>> _children = new List<TreeNode<T>>();

        public TreeNode(T value) {
            _value = value;
        }

        public TreeNode(TreeNode<T> tree) {
            this._value = tree._value;
            List<TreeNode<T>> newchildren = new List<TreeNode<T>>();
            foreach(TreeNode<T> node in _children) {
                newchildren.Add(new TreeNode<T>(node));
            }
            this._children = newchildren;
        }

        public TreeNode<T> this[int i] {
            get { return _children[i]; }
        }

        public TreeNode<T> Parent { get; private set; }

        public T Value { get { return _value; } }

        public ReadOnlyCollection<TreeNode<T>> Children {
            get { return _children.AsReadOnly(); }
        }

        public TreeNode<T> AddChild(T value) {
            var node = new TreeNode<T>(value) { Parent = this };
            _children.Add(node);
            return node;
        }

        public TreeNode<T>[] AddChildren(params T[] values) {
            return values.Select(AddChild).ToArray();
        }

        public bool RemoveChild(TreeNode<T> node) {
            return _children.Remove(node);
        }

        public void Traverse(Action<T> action) {
            action(Value);
            foreach (var child in _children)
                child.Traverse(action);
        }

        public IEnumerable<T> Flatten() {
            return new[] { Value }.Concat(_children.SelectMany(x => x.Flatten()));
        }

    }
}