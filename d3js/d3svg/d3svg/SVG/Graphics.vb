﻿Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Drawing.Text
Imports Microsoft.VisualBasic.Imaging

''' <summary>
''' SVG graphics device
''' </summary>
Public Class Graphics : Inherits IGraphics

    Public Overrides Property Clip As Region
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Region)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Overrides ReadOnly Property ClipBounds As RectangleF
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Overrides Property CompositingMode As CompositingMode
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As CompositingMode)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Overrides Property CompositingQuality As CompositingQuality
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As CompositingQuality)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Overrides ReadOnly Property DpiX As Single
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Overrides ReadOnly Property DpiY As Single
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Overrides Property InterpolationMode As InterpolationMode
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As InterpolationMode)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Overrides ReadOnly Property IsClipEmpty As Boolean
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Overrides ReadOnly Property IsVisibleClipEmpty As Boolean
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Overrides Property PageScale As Single
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Single)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Overrides Property PageUnit As GraphicsUnit
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As GraphicsUnit)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Overrides Property PixelOffsetMode As PixelOffsetMode
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As PixelOffsetMode)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Overrides Property RenderingOrigin As Point
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Point)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Overrides Property SmoothingMode As SmoothingMode
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As SmoothingMode)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Overrides Property TextContrast As Integer
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Integer)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Overrides Property TextRenderingHint As TextRenderingHint
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As TextRenderingHint)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Overrides Property Transform As Matrix
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Matrix)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Overrides ReadOnly Property VisibleClipBounds As RectangleF
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Overrides Sub AddMetafileComment(data() As Byte)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub Clear(color As Color)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub CopyFromScreen(upperLeftSource As Point, upperLeftDestination As Point, blockRegionSize As Size)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub CopyFromScreen(upperLeftSource As Point, upperLeftDestination As Point, blockRegionSize As Size, copyPixelOperation As CopyPixelOperation)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub CopyFromScreen(sourceX As Integer, sourceY As Integer, destinationX As Integer, destinationY As Integer, blockRegionSize As Size)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub CopyFromScreen(sourceX As Integer, sourceY As Integer, destinationX As Integer, destinationY As Integer, blockRegionSize As Size, copyPixelOperation As CopyPixelOperation)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub Dispose()
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawArc(pen As Pen, rect As Rectangle, startAngle As Single, sweepAngle As Single)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawArc(pen As Pen, rect As RectangleF, startAngle As Single, sweepAngle As Single)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawArc(pen As Pen, x As Single, y As Single, width As Single, height As Single, startAngle As Single, sweepAngle As Single)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawArc(pen As Pen, x As Integer, y As Integer, width As Integer, height As Integer, startAngle As Integer, sweepAngle As Integer)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawBezier(pen As Pen, pt1 As PointF, pt2 As PointF, pt3 As PointF, pt4 As PointF)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawBezier(pen As Pen, pt1 As Point, pt2 As Point, pt3 As Point, pt4 As Point)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawBezier(pen As Pen, x1 As Single, y1 As Single, x2 As Single, y2 As Single, x3 As Single, y3 As Single, x4 As Single, y4 As Single)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawBeziers(pen As Pen, points() As Point)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawBeziers(pen As Pen, points() As PointF)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawClosedCurve(pen As Pen, points() As PointF)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawClosedCurve(pen As Pen, points() As Point)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawClosedCurve(pen As Pen, points() As PointF, tension As Single, fillmode As FillMode)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawClosedCurve(pen As Pen, points() As Point, tension As Single, fillmode As FillMode)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawCurve(pen As Pen, points() As PointF)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawCurve(pen As Pen, points() As Point)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawCurve(pen As Pen, points() As Point, tension As Single)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawCurve(pen As Pen, points() As PointF, tension As Single)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawCurve(pen As Pen, points() As PointF, offset As Integer, numberOfSegments As Integer)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawCurve(pen As Pen, points() As Point, offset As Integer, numberOfSegments As Integer, tension As Single)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawCurve(pen As Pen, points() As PointF, offset As Integer, numberOfSegments As Integer, tension As Single)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawEllipse(pen As Pen, rect As RectangleF)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawEllipse(pen As Pen, rect As Rectangle)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawEllipse(pen As Pen, x As Integer, y As Integer, width As Integer, height As Integer)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawEllipse(pen As Pen, x As Single, y As Single, width As Single, height As Single)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawIcon(icon As Icon, targetRect As Rectangle)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawIcon(icon As Icon, x As Integer, y As Integer)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawIconUnstretched(icon As Icon, targetRect As Rectangle)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImage(image As Image, point As PointF)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImage(image As Image, rect As RectangleF)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImage(image As Image, destPoints() As PointF)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImage(image As Image, rect As Rectangle)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImage(image As Image, destPoints() As Point)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImage(image As Image, point As Point)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImage(image As Image, x As Single, y As Single)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImage(image As Image, x As Integer, y As Integer)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImage(image As Image, destPoints() As PointF, srcRect As RectangleF, srcUnit As GraphicsUnit)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImage(image As Image, destPoints() As Point, srcRect As Rectangle, srcUnit As GraphicsUnit)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImage(image As Image, destRect As Rectangle, srcRect As Rectangle, srcUnit As GraphicsUnit)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImage(image As Image, destRect As RectangleF, srcRect As RectangleF, srcUnit As GraphicsUnit)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImage(image As Image, x As Integer, y As Integer, srcRect As Rectangle, srcUnit As GraphicsUnit)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImage(image As Image, x As Single, y As Single, srcRect As RectangleF, srcUnit As GraphicsUnit)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImage(image As Image, destPoints() As PointF, srcRect As RectangleF, srcUnit As GraphicsUnit, imageAttr As ImageAttributes)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImage(image As Image, x As Integer, y As Integer, width As Integer, height As Integer)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImage(image As Image, destPoints() As Point, srcRect As Rectangle, srcUnit As GraphicsUnit, imageAttr As ImageAttributes)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImage(image As Image, x As Single, y As Single, width As Single, height As Single)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImage(image As Image, destPoints() As PointF, srcRect As RectangleF, srcUnit As GraphicsUnit, imageAttr As ImageAttributes, callback As Drawing.Graphics.DrawImageAbort)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImage(image As Image, destPoints() As Point, srcRect As Rectangle, srcUnit As GraphicsUnit, imageAttr As ImageAttributes, callback As Drawing.Graphics.DrawImageAbort)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImage(image As Image, destPoints() As PointF, srcRect As RectangleF, srcUnit As GraphicsUnit, imageAttr As ImageAttributes, callback As Drawing.Graphics.DrawImageAbort, callbackData As Integer)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImage(image As Image, destRect As Rectangle, srcX As Integer, srcY As Integer, srcWidth As Integer, srcHeight As Integer, srcUnit As GraphicsUnit)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImage(image As Image, destRect As Rectangle, srcX As Single, srcY As Single, srcWidth As Single, srcHeight As Single, srcUnit As GraphicsUnit)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImage(image As Image, destPoints() As Point, srcRect As Rectangle, srcUnit As GraphicsUnit, imageAttr As ImageAttributes, callback As Drawing.Graphics.DrawImageAbort, callbackData As Integer)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImage(image As Image, destRect As Rectangle, srcX As Integer, srcY As Integer, srcWidth As Integer, srcHeight As Integer, srcUnit As GraphicsUnit, imageAttr As ImageAttributes)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImage(image As Image, destRect As Rectangle, srcX As Single, srcY As Single, srcWidth As Single, srcHeight As Single, srcUnit As GraphicsUnit, imageAttrs As ImageAttributes)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImage(image As Image, destRect As Rectangle, srcX As Single, srcY As Single, srcWidth As Single, srcHeight As Single, srcUnit As GraphicsUnit, imageAttrs As ImageAttributes, callback As Drawing.Graphics.DrawImageAbort)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImage(image As Image, destRect As Rectangle, srcX As Integer, srcY As Integer, srcWidth As Integer, srcHeight As Integer, srcUnit As GraphicsUnit, imageAttr As ImageAttributes, callback As Drawing.Graphics.DrawImageAbort)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImage(image As Image, destRect As Rectangle, srcX As Integer, srcY As Integer, srcWidth As Integer, srcHeight As Integer, srcUnit As GraphicsUnit, imageAttrs As ImageAttributes, callback As Drawing.Graphics.DrawImageAbort, callbackData As IntPtr)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImage(image As Image, destRect As Rectangle, srcX As Single, srcY As Single, srcWidth As Single, srcHeight As Single, srcUnit As GraphicsUnit, imageAttrs As ImageAttributes, callback As Drawing.Graphics.DrawImageAbort, callbackData As IntPtr)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImageUnscaled(image As Image, point As Point)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImageUnscaled(image As Image, rect As Rectangle)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImageUnscaled(image As Image, x As Integer, y As Integer)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImageUnscaled(image As Image, x As Integer, y As Integer, width As Integer, height As Integer)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawImageUnscaledAndClipped(image As Image, rect As Rectangle)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawLine(pen As Pen, pt1 As Point, pt2 As Point)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawLine(pen As Pen, pt1 As PointF, pt2 As PointF)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawLine(pen As Pen, x1 As Single, y1 As Single, x2 As Single, y2 As Single)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawLine(pen As Pen, x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawLines(pen As Pen, points() As Point)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawLines(pen As Pen, points() As PointF)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawPath(pen As Pen, path As GraphicsPath)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawPie(pen As Pen, rect As RectangleF, startAngle As Single, sweepAngle As Single)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawPie(pen As Pen, rect As Rectangle, startAngle As Single, sweepAngle As Single)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawPie(pen As Pen, x As Single, y As Single, width As Single, height As Single, startAngle As Single, sweepAngle As Single)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawPie(pen As Pen, x As Integer, y As Integer, width As Integer, height As Integer, startAngle As Integer, sweepAngle As Integer)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawPolygon(pen As Pen, points() As Point)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawPolygon(pen As Pen, points() As PointF)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawRectangle(pen As Pen, rect As Rectangle)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawRectangle(pen As Pen, x As Integer, y As Integer, width As Integer, height As Integer)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawRectangle(pen As Pen, x As Single, y As Single, width As Single, height As Single)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawRectangles(pen As Pen, rects() As Rectangle)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawRectangles(pen As Pen, rects() As RectangleF)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawString(s As String, font As Font, brush As Brush, layoutRectangle As RectangleF)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawString(s As String, font As Font, brush As Brush, point As PointF)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawString(s As String, font As Font, brush As Brush, x As Single, y As Single)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawString(s As String, font As Font, brush As Brush, point As PointF, format As StringFormat)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawString(s As String, font As Font, brush As Brush, layoutRectangle As RectangleF, format As StringFormat)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub DrawString(s As String, font As Font, brush As Brush, x As Single, y As Single, format As StringFormat)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EndContainer(container As GraphicsContainer)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destPoint As Point, callback As Drawing.Graphics.EnumerateMetafileProc)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destPoint As PointF, callback As Drawing.Graphics.EnumerateMetafileProc)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destRect As Rectangle, callback As Drawing.Graphics.EnumerateMetafileProc)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destRect As RectangleF, callback As Drawing.Graphics.EnumerateMetafileProc)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destPoints() As PointF, callback As Drawing.Graphics.EnumerateMetafileProc)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destPoints() As Point, callback As Drawing.Graphics.EnumerateMetafileProc)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destPoint As PointF, callback As Drawing.Graphics.EnumerateMetafileProc, callbackData As IntPtr)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destRect As RectangleF, callback As Drawing.Graphics.EnumerateMetafileProc, callbackData As IntPtr)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destRect As Rectangle, callback As Drawing.Graphics.EnumerateMetafileProc, callbackData As IntPtr)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destPoint As Point, callback As Drawing.Graphics.EnumerateMetafileProc, callbackData As IntPtr)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destPoints() As PointF, callback As Drawing.Graphics.EnumerateMetafileProc, callbackData As IntPtr)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destPoints() As Point, callback As Drawing.Graphics.EnumerateMetafileProc, callbackData As IntPtr)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destRect As Rectangle, callback As Drawing.Graphics.EnumerateMetafileProc, callbackData As IntPtr, imageAttr As ImageAttributes)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destPoints() As Point, srcRect As Rectangle, srcUnit As GraphicsUnit, callback As Drawing.Graphics.EnumerateMetafileProc)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destPoint As Point, callback As Drawing.Graphics.EnumerateMetafileProc, callbackData As IntPtr, imageAttr As ImageAttributes)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destRect As RectangleF, callback As Drawing.Graphics.EnumerateMetafileProc, callbackData As IntPtr, imageAttr As ImageAttributes)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destRect As RectangleF, srcRect As RectangleF, srcUnit As GraphicsUnit, callback As Drawing.Graphics.EnumerateMetafileProc)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destPoints() As PointF, callback As Drawing.Graphics.EnumerateMetafileProc, callbackData As IntPtr, imageAttr As ImageAttributes)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destPoints() As PointF, srcRect As RectangleF, srcUnit As GraphicsUnit, callback As Drawing.Graphics.EnumerateMetafileProc)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destPoints() As Point, callback As Drawing.Graphics.EnumerateMetafileProc, callbackData As IntPtr, imageAttr As ImageAttributes)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destPoint As Point, srcRect As Rectangle, srcUnit As GraphicsUnit, callback As Drawing.Graphics.EnumerateMetafileProc)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destPoint As PointF, srcRect As RectangleF, srcUnit As GraphicsUnit, callback As Drawing.Graphics.EnumerateMetafileProc)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destPoint As PointF, callback As Drawing.Graphics.EnumerateMetafileProc, callbackData As IntPtr, imageAttr As ImageAttributes)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destRect As Rectangle, srcRect As Rectangle, srcUnit As GraphicsUnit, callback As Drawing.Graphics.EnumerateMetafileProc)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destPoints() As PointF, srcRect As RectangleF, srcUnit As GraphicsUnit, callback As Drawing.Graphics.EnumerateMetafileProc, callbackData As IntPtr)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destPoint As Point, srcRect As Rectangle, srcUnit As GraphicsUnit, callback As Drawing.Graphics.EnumerateMetafileProc, callbackData As IntPtr)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destPoint As PointF, srcRect As RectangleF, srcUnit As GraphicsUnit, callback As Drawing.Graphics.EnumerateMetafileProc, callbackData As IntPtr)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destPoints() As Point, srcRect As Rectangle, srcUnit As GraphicsUnit, callback As Drawing.Graphics.EnumerateMetafileProc, callbackData As IntPtr)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destRect As RectangleF, srcRect As RectangleF, srcUnit As GraphicsUnit, callback As Drawing.Graphics.EnumerateMetafileProc, callbackData As IntPtr)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destRect As Rectangle, srcRect As Rectangle, srcUnit As GraphicsUnit, callback As Drawing.Graphics.EnumerateMetafileProc, callbackData As IntPtr)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destPoint As Point, srcRect As Rectangle, unit As GraphicsUnit, callback As Drawing.Graphics.EnumerateMetafileProc, callbackData As IntPtr, imageAttr As ImageAttributes)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destPoints() As Point, srcRect As Rectangle, unit As GraphicsUnit, callback As Drawing.Graphics.EnumerateMetafileProc, callbackData As IntPtr, imageAttr As ImageAttributes)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destPoint As PointF, srcRect As RectangleF, unit As GraphicsUnit, callback As Drawing.Graphics.EnumerateMetafileProc, callbackData As IntPtr, imageAttr As ImageAttributes)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destRect As RectangleF, srcRect As RectangleF, unit As GraphicsUnit, callback As Drawing.Graphics.EnumerateMetafileProc, callbackData As IntPtr, imageAttr As ImageAttributes)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destPoints() As PointF, srcRect As RectangleF, unit As GraphicsUnit, callback As Drawing.Graphics.EnumerateMetafileProc, callbackData As IntPtr, imageAttr As ImageAttributes)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub EnumerateMetafile(metafile As Metafile, destRect As Rectangle, srcRect As Rectangle, unit As GraphicsUnit, callback As Drawing.Graphics.EnumerateMetafileProc, callbackData As IntPtr, imageAttr As ImageAttributes)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub ExcludeClip(region As Region)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub ExcludeClip(rect As Rectangle)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub FillClosedCurve(brush As Brush, points() As Point)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub FillClosedCurve(brush As Brush, points() As PointF)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub FillClosedCurve(brush As Brush, points() As PointF, fillmode As FillMode)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub FillClosedCurve(brush As Brush, points() As Point, fillmode As FillMode)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub FillClosedCurve(brush As Brush, points() As Point, fillmode As FillMode, tension As Single)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub FillClosedCurve(brush As Brush, points() As PointF, fillmode As FillMode, tension As Single)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub FillEllipse(brush As Brush, rect As RectangleF)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub FillEllipse(brush As Brush, rect As Rectangle)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub FillEllipse(brush As Brush, x As Integer, y As Integer, width As Integer, height As Integer)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub FillEllipse(brush As Brush, x As Single, y As Single, width As Single, height As Single)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub FillPath(brush As Brush, path As GraphicsPath)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub FillPie(brush As Brush, rect As Rectangle, startAngle As Single, sweepAngle As Single)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub FillPie(brush As Brush, x As Single, y As Single, width As Single, height As Single, startAngle As Single, sweepAngle As Single)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub FillPie(brush As Brush, x As Integer, y As Integer, width As Integer, height As Integer, startAngle As Integer, sweepAngle As Integer)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub FillPolygon(brush As Brush, points() As PointF)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub FillPolygon(brush As Brush, points() As Point)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub FillPolygon(brush As Brush, points() As PointF, fillMode As FillMode)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub FillPolygon(brush As Brush, points() As Point, fillMode As FillMode)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub FillRectangle(brush As Brush, rect As RectangleF)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub FillRectangle(brush As Brush, rect As Rectangle)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub FillRectangle(brush As Brush, x As Single, y As Single, width As Single, height As Single)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub FillRectangle(brush As Brush, x As Integer, y As Integer, width As Integer, height As Integer)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub FillRectangles(brush As Brush, rects() As Rectangle)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub FillRectangles(brush As Brush, rects() As RectangleF)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub FillRegion(brush As Brush, region As Region)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub Flush()
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub Flush(intention As FlushIntention)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub IntersectClip(rect As Rectangle)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub IntersectClip(rect As RectangleF)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub IntersectClip(region As Region)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub MultiplyTransform(matrix As Matrix)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub MultiplyTransform(matrix As Matrix, order As MatrixOrder)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub ReleaseHdc()
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub ReleaseHdc(hdc As IntPtr)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub ReleaseHdcInternal(hdc As IntPtr)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub ResetClip()
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub ResetTransform()
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub Restore(gstate As GraphicsState)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub RotateTransform(angle As Single)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub RotateTransform(angle As Single, order As MatrixOrder)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub ScaleTransform(sx As Single, sy As Single)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub ScaleTransform(sx As Single, sy As Single, order As MatrixOrder)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub SetClip(rect As Rectangle)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub SetClip(g As Drawing.Graphics)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub SetClip(path As GraphicsPath)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub SetClip(rect As RectangleF)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub SetClip(g As Drawing.Graphics, combineMode As CombineMode)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub SetClip(path As GraphicsPath, combineMode As CombineMode)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub SetClip(rect As RectangleF, combineMode As CombineMode)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub SetClip(region As Region, combineMode As CombineMode)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub SetClip(rect As Rectangle, combineMode As CombineMode)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub TransformPoints(destSpace As CoordinateSpace, srcSpace As CoordinateSpace, pts() As PointF)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub TransformPoints(destSpace As CoordinateSpace, srcSpace As CoordinateSpace, pts() As Point)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub TranslateClip(dx As Integer, dy As Integer)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub TranslateClip(dx As Single, dy As Single)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub TranslateTransform(dx As Single, dy As Single)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub TranslateTransform(dx As Single, dy As Single, order As MatrixOrder)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Function BeginContainer() As GraphicsContainer
        Throw New NotImplementedException()
    End Function

    Public Overrides Function BeginContainer(dstrect As Rectangle, srcrect As Rectangle, unit As GraphicsUnit) As GraphicsContainer
        Throw New NotImplementedException()
    End Function

    Public Overrides Function BeginContainer(dstrect As RectangleF, srcrect As RectangleF, unit As GraphicsUnit) As GraphicsContainer
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetContextInfo() As Object
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetHdc() As IntPtr
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetNearestColor(color As Color) As Color
        Throw New NotImplementedException()
    End Function

    Public Overrides Function IsVisible(rect As RectangleF) As Boolean
        Throw New NotImplementedException()
    End Function

    Public Overrides Function IsVisible(point As Point) As Boolean
        Throw New NotImplementedException()
    End Function

    Public Overrides Function IsVisible(point As PointF) As Boolean
        Throw New NotImplementedException()
    End Function

    Public Overrides Function IsVisible(rect As Rectangle) As Boolean
        Throw New NotImplementedException()
    End Function

    Public Overrides Function IsVisible(x As Integer, y As Integer) As Boolean
        Throw New NotImplementedException()
    End Function

    Public Overrides Function IsVisible(x As Single, y As Single) As Boolean
        Throw New NotImplementedException()
    End Function

    Public Overrides Function IsVisible(x As Single, y As Single, width As Single, height As Single) As Boolean
        Throw New NotImplementedException()
    End Function

    Public Overrides Function IsVisible(x As Integer, y As Integer, width As Integer, height As Integer) As Boolean
        Throw New NotImplementedException()
    End Function

    Public Overrides Function MeasureCharacterRanges(text As String, font As Font, layoutRect As RectangleF, stringFormat As StringFormat) As Region()
        Throw New NotImplementedException()
    End Function

    Public Overrides Function MeasureString(text As String, font As Font) As SizeF
        Throw New NotImplementedException()
    End Function

    Public Overrides Function MeasureString(text As String, font As Font, layoutArea As SizeF) As SizeF
        Throw New NotImplementedException()
    End Function

    Public Overrides Function MeasureString(text As String, font As Font, width As Integer) As SizeF
        Throw New NotImplementedException()
    End Function

    Public Overrides Function MeasureString(text As String, font As Font, layoutArea As SizeF, stringFormat As StringFormat) As SizeF
        Throw New NotImplementedException()
    End Function

    Public Overrides Function MeasureString(text As String, font As Font, origin As PointF, stringFormat As StringFormat) As SizeF
        Throw New NotImplementedException()
    End Function

    Public Overrides Function MeasureString(text As String, font As Font, width As Integer, format As StringFormat) As SizeF
        Throw New NotImplementedException()
    End Function

    Public Overrides Function MeasureString(text As String, font As Font, layoutArea As SizeF, stringFormat As StringFormat, ByRef charactersFitted As Integer, ByRef linesFilled As Integer) As SizeF
        Throw New NotImplementedException()
    End Function

    Public Overrides Function Save() As GraphicsState
        Throw New NotImplementedException()
    End Function
End Class
